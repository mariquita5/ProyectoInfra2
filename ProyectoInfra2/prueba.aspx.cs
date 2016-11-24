using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoInfra2.logicaNegocios;
using MySql.Data.MySqlClient;

namespace ProyectoInfra2
{
    public partial class prueba : System.Web.UI.Page
    {
        private MySqlCommand comandoUsuario;
        private string conection;
        private MySqlConnection conectado;
        private MySqlDataReader consulta;
        protected void Page_Load(object sender, EventArgs e)
        {

           
             
                conection = "Server=localhost;database=infra2 ;uid =root;password =elegance5;port=3306;";
                conectado = new MySqlConnection(conection);
                conectado.Open();
                comandoUsuario = new MySqlCommand();
                comandoUsuario.Connection = conectado;
                comandoUsuario.CommandText = "INSERT INTO usuario(correo,contraseña) VALUES(@Correo,@Contraseña)";
                comandoUsuario.Parameters.AddWithValue("@Correo", "maria");
                comandoUsuario.Parameters.AddWithValue("@Contraseña", "maria");


                 comandoUsuario.ExecuteNonQuery();
                conectado.Close();
                Response.Write("'conexion exitosa' ");

           


}
}
}