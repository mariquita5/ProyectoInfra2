using dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace logicaDeDatos
{
    public class DatoBitacora : ConexionBD
    {
        private MySqlCommand comandoBitacora;
        private String conection;
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

        public List<String[]> consultarBitacora(DTOBitacora bitacora)
        {
             List<String[]> bitacoras = new List<String[]>();
                conectarBD();
                conectado.Open();
                comandoBitacora = new MySqlCommand();
                comandoBitacora.Connection = conectado;
                comandoBitacora.CommandText = "select * from bitacora";
                consultaBitacora = comandoBitacora.ExecuteReader();

                while (consultaBitacora.Read())
                {
                    String[] bitacorita = { consultaBitacora.GetValue(0).ToString(), consultaBitacora.GetValue(1).ToString(), consultaBitacora.GetValue(2).ToString(), consultaBitacora.GetValue(3).ToString() };
                    bitacoras.Add(bitacorita);
                }

                conectado.Close();
                return bitacoras;

        }
    }
}