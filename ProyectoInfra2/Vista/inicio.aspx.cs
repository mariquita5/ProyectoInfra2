using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoInfra2.logicaNegocios;

namespace ProyectoInfra2.Vista
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            Server.Transfer("administrador.aspx", true);
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
               if (lblError.Text == String.Empty)
            
                {
 
                 Response.BufferOutput = true;
                 Response.Redirect("mua.aspx?User = " + txtUsuario.Text + txtcontraseña.Text);
                 }

                 else
                {
                 mensaje("Todos los campos tienen que estar ingresados");
               }
            

        }
        protected void Button3_Click(object sender, System.EventArgs e)
        {
            if (lblError.Text == String.Empty)

            {

                Response.BufferOutput = true;
                Response.Redirect("mua.aspx?User = " + txtUsuario.Text + txtcontraseña.Text);
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