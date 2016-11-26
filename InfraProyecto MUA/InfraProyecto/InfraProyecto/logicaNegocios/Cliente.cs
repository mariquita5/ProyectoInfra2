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
               
                conection = "Server=localhost;database=infra2 ;uid =root;password =2014104188;SslMode=None;";
                
                //conection = "Server=localhost;database=infra2 ;uid =root;password =elegance5;SslMode=None;";
                conectado = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }



        public bool verificarUsuario(String pCorreo, String pContraseña)
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
                string contraseña = consulta.GetValue(1).ToString();


                if (pCorreo == Correo & pContraseña == contraseña)
                {
                    return true;
                }
            }

            conectado.Close();
            return false;
        }

    }
}