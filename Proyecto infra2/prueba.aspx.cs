using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using logicaDeDatos;



namespace TutorCognitivoDS2
{
    public partial class prueba : System.Web.UI.Page
    {
       

        private static string conection;
        private static MySqlConnection conectar;
        private MySqlCommand comando;
        private MySqlDataReader consultaCategoria;





        protected void Page_Load(object sender, EventArgs e)
        {
          try
            {

                //DatoCarrera carrera = new DatoCarrera();
                //carrera.Consulta();
                
                //conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                //conectar = new MySqlConnection(conection);
                
               //conectar.Open();
                //comando = new MySqlCommand();
                //comando.Connection = conectar;
                //comando.CommandText = "Select idcarrera, nombrecarrera from carrera";
                
               

                // comando.CommandText = "INSERT INTO usuario(nombre,apellido1,apellido2,correo,contraseña,tipo,id_idcarrera) VALUES(@Nombre,@Apellido1,@Apellido2,@Correo,@Contraseña,@Tipo)";
                //comando.Parameters.AddWithValue("@Nombre", "maria");
                //comando.Parameters.AddWithValue("@Apellido1", "maria");
                //comando.Parameters.AddWithValue("@Apellido2", "maria");
                //comando.Parameters.AddWithValue("@Correo", "maria");
                //comando.Parameters.AddWithValue("@Contraseña", "maria");
                //comando.Parameters.AddWithValue("@Tipo", 3);
                //comando.Parameters.AddWithValue("@carrera", 32);
                //comando.ExecuteNonQuery();
                //conectar.Close();

                VerificacionDeDatos dato = new VerificacionDeDatos();

                if (dato.verificarCorreo("maria") == true)
               {
                    Response.Write("se encuentra en la base");
                }
                else
                {
                    Response.Write("no se encuentra en la base");
                }


                // string tutores= "SELECT nombre FROM tutor Limit 0";

                //MySqlCommand comando2 = new MySqlCommand(tutores,conectar);
                //MySqlDataReader lectura = comando2.ExecuteReader();

                //  while (lectura.Read())
                // {
                // string nombre = lectura.GetString(0);

                // }

                //Response.Write("'conexion exitosa' ");
               
            }
           catch (Exception)
           {
                Response.Write("'conexion no exitosa' ");

            }
       }
  }
}