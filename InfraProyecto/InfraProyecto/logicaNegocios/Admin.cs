using System;
using System.Collections.Generic;
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

        public void conectarBD2()
        {
            try
            {

                conection = "Server=us-cdbr-iron-east-04.cleardb.net;database=ad_0729aa65b5d7b9c ;uid =bbaf6d2dfeba49;password =f3f6269b;SslMode=None;";
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
                // conectarBD();
                conectarBD2();
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
                //conectarBD();
                conectarBD2();
                conectado.Open();
                comandoUsuario = new MySqlCommand();
                comandoUsuario.Connection = conectado;

                comandoUsuario.CommandText = "Delete from usuario where correo='" + pCorreo + "';";
                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
            }
            catch (Exception)
            {

            }
        }


        public bool verificarContrasena(String pContraseña)
        {
            //conectarBD();
            conectarBD2();
            conectado.Open();
            comandoUsuario = new MySqlCommand();
            comandoUsuario.Connection = conectado;
            comandoUsuario.CommandText = "Select * from admin";
            consulta = comandoUsuario.ExecuteReader();
            while (consulta.Read())
            {
                string contraseña = consulta.GetValue(0).ToString();


                if ( pContraseña == contraseña)
                {
                    return true;
                }
            }

            conectado.Close();
            return false;
        }

  


    }
}