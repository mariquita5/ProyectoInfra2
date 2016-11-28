using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProyectoInfra2.logicaNegocios
{
    public class Cliente
    {
        private MySqlCommand comandoUsuario;
        private string conection;
        private MySqlConnection conectado;
        private MySqlDataReader consulta;

        public void conectarBD()
        {
            try
            {
               
               
                conection = "Server=localhost;database=hmailserver ;uid =root;password =elegance5;SslMode=None;";
                conectado = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }


        public bool verificarUsuario(String pCorreo)
        {
            conectarBD();
            conectado.Open();
            comandoUsuario = new MySqlCommand();
            comandoUsuario.Connection = conectado;
            comandoUsuario.CommandText = "Select * from hm_accounts";
            consulta = comandoUsuario.ExecuteReader();
            while (consulta.Read())
            {
                string Correo = consulta.GetValue(3).ToString();

                if (pCorreo == Correo)
                {
                    return true;
                }
            }

            conectado.Close();
            return false;
        }

    }
}