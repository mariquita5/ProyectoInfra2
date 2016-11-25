using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoInfra2.logicaNegocios;
using MySql.Data.MySqlClient;
using mySMTP;
using System.Net.Mail;


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
            string userName;
            userName = User.Identity.Name;
            HttpClientCertificate cert = Request.ClientCertificate;
            if (cert.IsPresent)
            {
                Response.Write(" certificate was found.");


        }
            else
            {
                Response.Write("No certificate was found.");
             }

        }
    }
}