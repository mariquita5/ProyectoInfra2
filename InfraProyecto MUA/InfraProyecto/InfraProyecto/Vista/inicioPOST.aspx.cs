using System;
using ProyectoInfra2.logicaNegocios;
using System.Web.UI;

namespace ProyectoInfra2.Vista
{
    public partial class inicioPOST : System.Web.UI.Page
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
                if (validacion == true)
                {
                    Response.BufferOutput = true;
                    Response.Redirect("mua.aspx?User = " + txtUsuario.Text + txtcontraseña.Text);

                    //var postData = "thing1=hello";
                    //postData += "&thing2=world";
                    //var data = Encoding.ASCII.GetBytes(postData);

                    //request.Method = "POST";
                    //request.ContentType = "application/x-www-form-urlencoded";
                    //request.ContentLength = data.Length;

                    //using (var stream = request.GetRequestStream())
                    //{
                    //    stream.Write(data, 0, data.Length);
                    //}

                    //var response = (HttpWebResponse)request.GetResponse();

                    //var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();






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
