using System;
using System.Web.UI;
using ProyectoInfra2.logicaNegocios;


namespace ProyectoInfra2.Vista
{
    public partial class administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            
                Admin administrador = new logicaNegocios.Admin();
                administrador.registrarUsuario(txtUsuario.Text, txtContraseña.Text);
                mensaje("Usuario registrado con exito");


        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {

            Admin administrador = new logicaNegocios.Admin();
            administrador.eliminarUsuario(txtUsuario.Text);
            mensaje("Usuario eliminado con exito");

        }



        public void mensaje(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);
        }





    }
}