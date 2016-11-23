using controlador;
using dto;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorCognitivoDS2.TutorCognitivo.dto;
using validacion;

namespace TutorCognitivoDS2.vista
{
    public partial class ConfirmarTutor : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        String User;

        protected void Page_Load(object sender, EventArgs e)
        {
            User = Request.QueryString["User"];

            if (User == String.Empty)
            {
                Response.BufferOutput = true;
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            DTOConfirmacion sConfirmacion = new DTOConfirmacion(txtContraseña1.Text, txtContraseña2.Text);

            lblError.Text = Validacion.validarConfirmacion(sConfirmacion);

            if (lblError.Text == String.Empty)
            {
                //Cambiar la contraseña
                Response.Redirect("MainTutor.aspx?User=" + User);
                //controlador.mensajeInterfaz("Datos reemplazados correctamente");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                Response.BufferOutput = true;
                Response.Redirect("Login.aspx");
            }
        }

        public void mensajeInterfaz(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);
        }
    }
}