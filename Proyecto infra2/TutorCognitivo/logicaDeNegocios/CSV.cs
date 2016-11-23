using System.Collections.Generic;
using System.IO;

namespace logicaDeNegocios
{
    public class CSV : Bitacora
    {
        StringWriter writer = new StringWriter();
        List<object> listaRegistro = new List<object>();

        public CSV(List<object> pRegistro)
        {
            listaRegistro = pRegistro;
            crearArchivo();
        }

        public override void actualizar()
        {
        }

        public override void escribirArchivo()
        {
            writer.WriteLine("\"Usuario\";\"Accion\";\"Fecha y Hora\"");

            for (int i = 0; listaRegistro.Count > i; i++)
            {
                writer.WriteLine(string.Format("\"{0}\";\"{1}\";\"{2}\"",
                //listaRegistro.getUsuario(), listaRegistro.getAccion(), DateTime.Now));
                "Juanito", "Consulta a tutor", "HORA"));
            }
            System.Web.HttpContext.Current.Response.Write(writer.ToString());
            System.Web.HttpContext.Current.Response.Flush();
            System.Web.HttpContext.Current.Response.End();
        }

        public override void crearArchivo()
        {
            string attachment = "attachment; filename=BitacoraTutorCognitivo.csv";

            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.ClearHeaders();
            System.Web.HttpContext.Current.Response.ClearContent();
            System.Web.HttpContext.Current.Response.AddHeader("content-disposition", attachment);
            System.Web.HttpContext.Current.Response.ContentType = "text/csv";
            System.Web.HttpContext.Current.Response.AddHeader("Pragma", "public");
            escribirArchivo();
        }
    }
}