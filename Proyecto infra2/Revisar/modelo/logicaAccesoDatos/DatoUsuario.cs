using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data;
using dto;
using TutorCognitivoDS2.modelo.logicaAccesoDatos;

namespace TutorCognitivoDS2.accesoADatos
{
    public class DatoUsuario:ConexionBD

    {

        private MySqlCommand comandoUsuario;
        private string conection;
        private MySqlConnection conectado;
        private MySqlDataReader consulta;


        public void conectarBD()
        {
            try
            {
                conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                conectado = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }


        public void registrarUsuario(DTOUsuario usuario)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoUsuario = new MySqlCommand();
                comandoUsuario.Connection = conectado;
                comandoUsuario.CommandText = "INSERT INTO usuario(Nombre,Apellido1,Apellido2,Correo,Contraseña,Tipo) VALUES(@Nombre,@Apellido1,@Apellido2,@Correo,@Contraseña,@Tipo)";
                comandoUsuario.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comandoUsuario.Parameters.AddWithValue("@Apellido1", usuario.Apellido1);
                comandoUsuario.Parameters.AddWithValue("@Apellido2", usuario.Apellido2);
                comandoUsuario.Parameters.AddWithValue("@Correo", usuario.Correo);
                comandoUsuario.Parameters.AddWithValue("@Contraseña", usuario.Contraseña1);
                comandoUsuario.Parameters.AddWithValue("@Tipo", 3);
                comandoUsuario.ExecuteNonQuery();
                conectado.Close();


            }
            catch (Exception)
            {

            }

        }

        public void consultarTutores()
        {
            try
            {

                

            }
            catch
            {
            }


        }

        public void consultarFinales()
        {
            try
            {



            }
            catch
            {
            }


        }
        public void consultarTutor(int ID)
        {
            try
            {



            }
            catch
            {
            }


        }

        public void consultarFinal(int ID)
        {
            try
            {



            }
            catch
            {
            }


        }



    }
}