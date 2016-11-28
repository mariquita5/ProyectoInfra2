using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InfraProyecto.Vista
{
    public partial class Telnet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            procesar("maria@rubenabix.com", "majomadrig5@gmail.com", "hola", "dos");
        }

        bool WriteToStream(ref NetworkStream nwstream, string strLine)
        {
            string strString2Send = strLine + "\r\n";
            Byte[] arr2Send = Encoding.ASCII.GetBytes(strString2Send.ToCharArray());
            try
            {
                nwstream.Write(arr2Send, 0, arr2Send.Length);
            }
            catch
            {
                return false;
            }
            return true;
        }

        bool ReadFromStream(ref NetworkStream nwstream, out string strMessage)
        {
            byte[] readBuffer = new byte[255];
            int nLength = nwstream.Read(readBuffer, 0, readBuffer.Length);
            strMessage = Encoding.ASCII.GetString(readBuffer, 0, nLength);
            return (3 <= readBuffer[0]); // 2 success, 3 informational
        }


        public void procesar(string from, string to, string asunto, string mensaje)
        {

            string strEmailServer = "192.168.1.5";
            string strSendTo = to;
            string strMailFrom = from;
            string strSubject = asunto;
            string strMensaje = mensaje;

            TcpClient tcpc = new TcpClient();
            try
            {
                tcpc.Connect(strEmailServer, 25);
            }
            catch (SocketException socketEx)
            {
                Response.Write("Connection Error: " + socketEx.ToString());
            }

            NetworkStream nwstream = tcpc.GetStream();
            string strResponse;

            WriteToStream(ref nwstream, "EHLO 192.168.1.5");
            ReadFromStream(ref nwstream, out strResponse);
            Response.Write(strResponse);

            WriteToStream(ref nwstream, "MAIL FROM: " + strMailFrom);
            ReadFromStream(ref nwstream, out strResponse);
            Response.Write(strResponse);

            WriteToStream(ref nwstream, "RCPT TO: " + strSendTo);
            ReadFromStream(ref nwstream, out strResponse);
            Response.Write(strResponse);

            WriteToStream(ref nwstream, "DATA");
            ReadFromStream(ref nwstream, out strResponse);
            Response.Write(strResponse);

            WriteToStream(ref nwstream, "Subject: " + strSubject + "\r\n\r\n" + strMensaje);
            ReadFromStream(ref nwstream, out strResponse);
            Response.Write(strResponse );

            WriteToStream(ref nwstream, ".");
            ReadFromStream(ref nwstream, out strResponse);
            Response.Write(strResponse);
        }
    }
}