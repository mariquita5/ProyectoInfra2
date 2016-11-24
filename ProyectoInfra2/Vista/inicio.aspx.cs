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

            Server.Transfer("mua.aspx", true);
        }

    }
}