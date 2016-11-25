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
                conection = "Server=localhost;database=infra2 ;uid =root;password =elegance5;SslMode=None;";
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

                comandoUsuario.CommandText = comandoUsuario.CommandText = "INSERT INTO usuario(correo,contraseña) VALUES(@Correo,@Contraseña)";
                comandoUsuario.Parameters.AddWithValue("@Correo", pCorreo);
                comandoUsuario.Parameters.AddWithValue("@Contraseña", pContraseña);

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

                comandoUsuario.CommandText = "Delete from usuario where correo='" + pCorreo +"';";
                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
            }
            catch (Exception)
            {

            }
        }


        public bool verificarUsuario(String pCorreo,String pContraseña)
        {
            conectarBD();
            conectado.Open();
            comandoUsuario = new MySqlCommand();
            comandoUsuario.Connection = conectado;
            comandoUsuario.CommandText = "Select * from usuario";
            consulta = comandoUsuario.ExecuteReader();
            while (consulta.Read())
            {
                string Correo = consulta.GetValue(0).ToString();
                string contraseña= consulta.GetValue(1).ToString();


                if (pCorreo == Correo & pContraseña==contraseña)
                {
                    return true;
                }
            }

            conectado.Close();
            return false;
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