using controlador;
using dto;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using validacion;

namespace TutorCognitivoDS2.vista
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    List<String[]> pLista = controlador.obtenerListaCarreras();

                    for (int i = 0; i < pLista.Count; i++)
                    {
                        ListItem item = new ListItem(pLista[i][1].ToString(), pLista[i][0].ToString());
                        ddlCarrera.Items.Add(item);
                    }
                }
                catch
                {
                    ddlCarrera.Items.Clear();
                }

                txtContraseña1.Attributes.Add("value", txtContraseña1.Text);
                txtContraseña1.Attributes.Add("value", txtContraseña1.Text);
                btnCancelar.Attributes["Onclick"] = "return confirm('¿Está seguro? Se perderán los datos')";
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOUsuario sUsuario = new DTOUsuario(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                    txtCorreo.Text, txtContraseña1.Text, txtContraseña2.Text, Int32.Parse(ddlCarrera.SelectedValue));

                lblError.Text = Validacion.validarRegistro(sUsuario);

                if (lblError.Text == String.Empty)
                {
                    controlador.insertarUsuarioFinal(sUsuario);
                    mensajeInterfaz("Usuario registrado correctamente");
                    Response.Redirect("Login.aspx");
                }
            }
            catch
            {
                mensajeInterfaz("Error al insertar el usuario");
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