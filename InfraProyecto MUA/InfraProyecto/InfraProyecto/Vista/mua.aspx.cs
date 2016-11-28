using System;
using System.Collections.Specialized;
using System.Web.UI;
using InfraProyecto.logicaNegocios;

namespace ProyectoInfra2.Vista
{
    public partial class mua : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //obtener los credenciales del usuario metodo get
            // Request.QueryString["user"];
            // Request.QueryString["password"];
        }
        protected void Button2_Click(object sender, System.EventArgs e)
        {

            // obtener credenciales metodo post
            mensaje(Request.QueryString["user"] + Request.QueryString["password"]);

            NameValueCollection nvc = Request.Form;

            mensaje(nvc["txtUsuario"] + nvc["txtcontraseña"]);

            Correo correo = new Correo();
            //correo.procesar();

        }

        public void mensaje(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);
        }

    }
}