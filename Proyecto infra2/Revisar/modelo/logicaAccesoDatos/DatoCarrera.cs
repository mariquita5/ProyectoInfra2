using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorCognitivoDS2.modelo.logicaAccesoDatos;

namespace TutorCognitivoDS2.accesoADatos
{
    public class DatoCarrera:ConexionBD
    {
        private MySqlCommand comando2;
        private string conection;
        private MySqlConnection conectar;
        MySqlDataReader lectura;

        public void conectarBD()
        {
            try
            {
                conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                conectar = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }

        public DropDownList cargarListBox()
        {
            conectarBD();
            conectar.Open();
            comando2 = new MySqlCommand();
            comando2.Connection = conectar;
            comando2.CommandText = "SELECT IDCarrera,Nombre From carrera";
            lectura = comando2.ExecuteReader();

            DropDownList sCarrera = new DropDownList();

            sCarrera.DataSource = lectura;
            sCarrera.DataTextField = "Nombre";
            sCarrera.DataValueField = "IDCarrera";
            sCarrera.DataBind();

            conectar.Close();

            return sCarrera;
        }

    }
}