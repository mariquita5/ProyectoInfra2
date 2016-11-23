using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace logicaDeNegocios
{
    public class XLS : Bitacora
    {
        public List<object> listaRegistro = new List<object>();
        public DataTable bitacora = new DataTable("Listado");
        public GridView grid = new GridView();

        public XLS(List<object> pRegistro)
        {
            listaRegistro = pRegistro;
            crearArchivo();
        }

        public override void actualizar()
        {
        }

        public override void escribirArchivo()
        {
            for (int i = 0; listaRegistro.Count > i; i++)
            {
                bitacora.Rows.Add("Juanito", "Entrenamiento", 300);
                //bitacora.Rows.Add(listaRegistro.getUsuario(), listaRegistro.getAccion(), DateTime.Now);
            }
        }

        public override void crearArchivo()
        {
            bitacora.Columns.Add("Usuario", typeof(string));
            bitacora.Columns.Add("Acción ", typeof(string));
            bitacora.Columns.Add("Fecha y Hora ", typeof(int));
            escribirArchivo();

            grid.DataSource = bitacora;
            grid.DataBind();

            System.Web.HttpContext.Current.Response.ClearContent();
            System.Web.HttpContext.Current.Response.Buffer = true;
            System.Web.HttpContext.Current.Response.AddHeader("content-disposition", "attachment; filename=BitacoraTutorCognitivo.xls");
            System.Web.HttpContext.Current.Response.ContentType = "application/ms-excel";


            System.Web.HttpContext.Current.Response.Charset = "";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            grid.RenderControl(htw);

            System.Web.HttpContext.Current.Response.Output.Write(sw.ToString());
            System.Web.HttpContext.Current.Response.Flush();
            System.Web.HttpContext.Current.Response.End();
        }
    }
}