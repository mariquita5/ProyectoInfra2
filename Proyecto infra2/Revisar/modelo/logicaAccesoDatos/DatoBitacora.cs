using System;
using MySql.Data.MySqlClient;
using TutorCognitivoDS2.modelo.logicaAccesoDatos;
using dto;

namespace TutorCognitivoDS2.accesoADatos
{
    public class DatoBitacora : ConexionBD
    {
        private MySqlCommand comandoBitacora;
        private string conection;
        private MySqlConnection conectado;
        private MySqlDataReader consultaBitacora;


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

        public void registrarBitacora(DTOBitacora bitacora)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoBitacora = new MySqlCommand();
                comandoBitacora.Connection = conectado;
                comandoBitacora.CommandText = "INSERT INTO usuario(fechaHora,Accion,contraseña) VALUES(@fechaHora,@accion,@contraseña)";
                comandoBitacora.Parameters.AddWithValue("@fechaHora", bitacora.FechaHora);
                comandoBitacora.Parameters.AddWithValue("@accion", bitacora.Accion);
                comandoBitacora.Parameters.AddWithValue("@contraseña", bitacora.Contraseña);
                comandoBitacora.ExecuteNonQuery();
                conectado.Close();


            }
            catch (Exception)
            {

            }

        }

        public void consultarBitacora(DTOBitacora bitacora)
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