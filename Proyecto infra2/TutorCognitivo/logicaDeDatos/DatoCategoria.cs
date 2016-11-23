using dto;
using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    //clase que gestiona todo lo relacionado con categoria
    public class DatoCategoria : ConexionBD
    {
        private MySqlCommand comandoCategoria;
        private String coneccion;
        private MySqlConnection conectado;
        private MySqlDataReader consultaCategoria;

        public void conectarBD()
        {
            try
            {
                coneccion = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                conectado = new MySqlConnection(coneccion);
            }
            catch (Exception)
            {

            }
        }

        public void registrarCategoria(DTOCategoria categoria)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoCategoria = new MySqlCommand();
                comandoCategoria.Connection = conectado;
                comandoCategoria.CommandText = "INSERT INTO categoria(Nombre) VALUES(@Nombre)";
                comandoCategoria.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                comandoCategoria.ExecuteNonQuery();
                conectado.Close();


            }
            catch (Exception)
            {

            }
        }

      
    }
}