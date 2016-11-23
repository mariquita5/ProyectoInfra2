using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProyectoInfra2.logicaNegocios
{
    public class Admin
    {
        private MySqlCommand comandoUsuario;
        private string conection;
        private MySqlConnection conectado;
        private MySqlDataReader consulta;

        public void conectarBD()
        {
            try
            {
                conection = "Server = LAPTOP-08ID3743;database=infra2 ;uid =root;password =elegance5;SslMode=None;";
                conectado = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }
        public void registrarUsuario(String pCorreo, String pContraseña)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoUsuario = new MySqlCommand();
                comandoUsuario.Connection = conectado;

                comandoUsuario.CommandText = "INSERT INTO usuario(correo,contraseña) "
                       + "VALUES('" + pCorreo + "','" + pContraseña+ ")";
           
                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
            }
            catch (Exception)
            {

            }
        }

        public void eliminarUsuario(String pCorreo)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoUsuario = new MySqlCommand();
                comandoUsuario.Connection = conectado;

                comandoUsuario.CommandText = "DELETE FROM usuario WHERE correo = "+pCorreo;
                       

                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
            }
            catch (Exception)
            {

            }
        }

        public List<String[]> consultarUsuarios()
        {
            List<String[]> usuarios= new List<String[]>();
            conectarBD();
            conectado.Open();
            comandoUsuario = new MySqlCommand();
            comandoUsuario.Connection = conectado;
            comandoUsuario.CommandText = "select * from usuario";
            consulta = comandoUsuario.ExecuteReader();

            while (consulta.Read())
            {

                String[] usuario = { consulta.GetValue(0).ToString(), consulta.GetValue(1).ToString()};

               usuarios.Add(usuario);

            }

            conectado.Close();

            return usuarios;
        }


    }
}