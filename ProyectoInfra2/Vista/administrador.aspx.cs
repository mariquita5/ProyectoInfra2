using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            if (lblError.Text == String.Empty)
            {
            Admin administrador = new logicaNegocios.Admin();
            administrador.registrarUsuario(txtUsuario.Text, txtContraseña.Text);
            mensaje("Usuario registrado con exito");

            }
            else
            {
                mensaje("Ingrese todos los campos");
            }


        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, System.EventArgs e)
        {

        }


        public void mensaje(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);
        }





    }
}