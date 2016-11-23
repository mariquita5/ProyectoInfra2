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

            try
            {
                conectado.Open();
                conection = "Server=LAPTOP-08ID3743;database=infra2 ;uid =root;password =elegance5;SslMode=None;";
                conectado = new MySqlConnection(conection);
                comandoUsuario.CommandText = "INSERT INTO infra2.usuario(correo,contraseña) VALUES(@Correo,@Contraseña)";
                comandoUsuario.Parameters.AddWithValue("@Correo", "maria");
                comandoUsuario.Parameters.AddWithValue("@Contraseña", "maria");

                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
                Response.Write("'conexion exitosa' ");

            }
           catch (Exception)
           {
                Response.Write("'conexion no exitosa' ");

            }


}
}
}