using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace ProyectoInfra2.Vista
{
    public partial class LoginHTPPS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, System.EventArgs e)

        {
            bool isPersistent = false;
            string username = txtUsuario.Text;
            string password = txtcontraseña.Text;
          

            if (lblError.Text == String.Empty)

            {

                string userData = "Aplicacion segura para el usuario.";

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                username, DateTime.Now,DateTime.Now.AddMinutes(30),isPersistent,userData,
                FormsAuthentication.FormsCookiePath);
                string encTicket = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                Response.Redirect("mua.aspx?User = " + username + password);
            }

            else
            {
                mensaje("Todos los campos tienen que estar ingresados");
            }


        }
        public void mensaje(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);
        }


    }
}