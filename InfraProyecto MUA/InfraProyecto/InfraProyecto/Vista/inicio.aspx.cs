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

       
        protected void Button2_Click(object sender, System.EventArgs e)
        {
            if (lblError.Text == String.Empty)
            {
              Cliente cliente = new Cliente();
                bool validacion = cliente.verificarUsuario(txtUsuario.Text, txtcontraseña.Text);
                if(validacion== true)
                {
                    Response.BufferOutput = true;
                Response.Redirect("mua.aspx?User = " + txtUsuario.Text + txtcontraseña.Text);
                }
                else
                {
                    mensaje("Usuario no registrado");

                }
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