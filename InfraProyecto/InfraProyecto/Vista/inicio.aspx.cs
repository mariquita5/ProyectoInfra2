using System;
using System.Web.UI;
using ProyectoInfra2.logicaNegocios;

namespace ProyectoInfra2.Vista
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void Button3_Click(object sender, System.EventArgs e)
        {
            if (lblError.Text == String.Empty)

            {
                Admin administrador2 = new logicaNegocios.Admin();
               bool validacion= administrador2.verificarContrasena(txtcontraseña.Text);
                if(validacion==true)
                {

                Response.BufferOutput = true;
                Response.Redirect("administrador.aspx?User = " + txtcontraseña.Text);
                }
                else
                {
                    mensaje("Contraseña incorrecta");
                }
            }

            else
            {
                mensaje("La contraseña debe ser ingresada");
            }


        }





        public void mensaje(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);
        }
    }
}