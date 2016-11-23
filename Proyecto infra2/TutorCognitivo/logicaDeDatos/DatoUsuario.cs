using dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace logicaDeDatos
{
    //clase que gestiona todo lo relacionado a lo de los usuarios en la BD 
    public class DatoUsuario : ConexionBD
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

                comandoUsuario.CommandText = "INSERT INTO usuario(nombre,apellido1,apellido2,correo,contrasena,tipo,carrera_idcarrera) "
                       + "VALUES('" + usuario.Nombre + "','" + usuario.Apellido1 + "','" + usuario.Apellido2 + "','" + usuario.Correo
                       + "','" + usuario.Contraseña1 + "',3," + usuario.Carrera + ")";

                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
            }
            catch (Exception)
            {

            }
        }

        public List<String[]> consultarTutores()
        {
            List<String[]> tutores = new List<String[]>();
            conectarBD();
            conectado.Open();
            comandoUsuario = new MySqlCommand();
            comandoUsuario.Connection = conectado;
            comandoUsuario.CommandText = "select * from usuario where tipo=2";
            consulta = comandoUsuario.ExecuteReader();

            while (consulta.Read())
            {
                
                String[] tutor = { consulta.GetValue(0).ToString(), consulta.GetValue(1).ToString(), consulta.GetValue(2).ToString(), consulta.GetValue(3).ToString(),
           consulta.GetValue(4).ToString(),consulta.GetValue(5).ToString(),consulta.GetValue(6).ToString() };

            tutores.Add(tutor);

            }

            conectado.Close();

            return tutores;
        }


        public List<String[]> consultarFinales()
        {
            List<String[]>  finales = new List<String[]>();
            conectarBD();
            conectado.Open();
            comandoUsuario = new MySqlCommand();
            comandoUsuario.Connection = conectado;
            comandoUsuario.CommandText = "select * from usuario where tipo=3";
            consulta = comandoUsuario.ExecuteReader();

            while (consulta.Read())
            {

                String[] tutor = { consulta.GetValue(0).ToString(), consulta.GetValue(1).ToString(), consulta.GetValue(2).ToString(), consulta.GetValue(3).ToString(),
           consulta.GetValue(4).ToString(),consulta.GetValue(5).ToString(),consulta.GetValue(6).ToString() };

              finales.Add(tutor);

            }

            conectado.Close();

            return finales;
        }    
    }
}