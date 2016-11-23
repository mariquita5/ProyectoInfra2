using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace logicaDeDatos
{
    public class DatoCarrera : ConexionBD
    {
        private MySqlCommand comandoCarrera;
        private String conection;
        private MySqlConnection conectado;
        private MySqlDataReader consultaCarrera;

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



        public List<String[]> Consulta()
        {
            List<String[]> carreras = new List<String[]>();
            conectarBD();
            conectado.Open();
            comandoCarrera = new MySqlCommand();
            comandoCarrera.Connection = conectado;
            comandoCarrera.CommandText = "Select idcarrera, nombrecarrera from carrera";
            consultaCarrera = comandoCarrera.ExecuteReader();

            while (consultaCarrera.Read())
            {
                String[] carrera = { consultaCarrera.GetValue(0).ToString(), consultaCarrera.GetValue(1).ToString() };
                carreras.Add(carrera);
            }

            conectado.Close();
            return carreras;
        }
    }
}