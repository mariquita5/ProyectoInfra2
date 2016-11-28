using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using hMailServer;

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
               
                   
               conection = "Server=localhost;database=hmailserver;uid =root;password =elegance5;SslMode=None;";
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


                conection = "Server=localhost;database=infra2;uid =root;password =elegance5;SslMode=None;";
                conectado = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }





        public void registrarUsuario(String pUsuario, String pContraseña)
        {
            try
            {
                hMailServer.Application aplicacion = new hMailServer.Application();
                aplicacion.Authenticate("Administrador", "12345");
                var domain = aplicacion.Domains.ItemByName["rubenabix.com"];
                var account = domain.Accounts.Add();
                account.Address = pUsuario + "rubenabix.com";
                account.Password = pContraseña;
                account.Active = true;

                account.Save();


            }
            catch (Exception)
            {

            }
        }


        public void EliminarUsuario(String pCorreo)
        {
            try
            {
                System.Type hMailServerCOM = System.Type.GetTypeFromProgID("hMailServer.Application");
                dynamic hMailServerInstance = Activator.CreateInstance(hMailServerCOM);
                hMailServerInstance.Authenticate("Administrator", "12345");
                hMailServerInstance.Settings.Routes.Refresh();
                dynamic Domain = hMailServerInstance.Domains.ItemByName("rubenabix.com");
                dynamic account = Domain.Accounts.ItemByAddress(pCorreo);
               //account.Save;

            }
            catch (Exception)
            {

            }
        }

        public void registrarUsuarioBD(String pCorreo, String pContraseña)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoUsuario = new MySqlCommand();
                comandoUsuario.Connection = conectado;

                comandoUsuario.CommandText = comandoUsuario.CommandText = "INSERT INTO hm_accounts(accountid,accountdomainid,accountadminlevel,accountactive,accountaddress,accountpassword) VALUES(@accountaddress,@accountpassword)";
                comandoUsuario.Parameters.AddWithValue("@accountaddress", pCorreo);
                comandoUsuario.Parameters.AddWithValue("@Contraseña", pContraseña);

                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
            }
            catch (Exception)
            {

            }
        }

        public void eliminarUsuarioBD(String pCorreo)
        {
            try
            {
                conectarBD();
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


        public bool verificarContrasenaAdmin(String pContraseña)
        {
           
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