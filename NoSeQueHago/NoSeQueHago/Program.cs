using mySMTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NoSeQueHago
{
    class Program
    {
        public static void prueba1()
        {
            System.Web.Mail.MailMessage mail = new System.Web.Mail.MailMessage();
            mail.From = "admin@infratec.com";
            mail.To = "jvega@infratec.com";
            mail.Subject = "Prueba";
            mail.Body = "Hola luuuuuu";

            SmtpDirect.Send(mail);
        }

        public static void prueba2()
        {
            MailMessage email = new MailMessage();
            //email.To.Add(new MailAddress("lucia@infra2ati.com"));
            //email.From = new MailAddress("jvega@infra2ati.com");
            email.To.Add(new MailAddress("lsolis@infratec.com"));
            email.From = new MailAddress("jvega@infratec.com");
            email.Subject = "Asunto ( Hola Luuuuuuuuuu ) ";
            email.Body = "Cualquier contenido en <b>HTML</b> para enviarlo por correo electrónico.";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            //smtp.Host = "infra2ati.com";
            smtp.Host = "infratec.com";
            smtp.Port = 2525;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential("lucia@infra2ati.com", "hola1234");
            smtp.Credentials = new NetworkCredential("admin@infratec.com", "1234567890");

            string output = null;

            try
            {
                smtp.Send(email);
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }

            Console.WriteLine(output);
        }

        public static void prueba3()
        {
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add("jvega@infratec.com");

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Hola luuuuu";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = "Texto del contenio del mensaje de correo";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("lsolis@infratec.com");
            
            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential(mmsg.From.Address, "1234567890");

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
            /*
            cliente.Port = 587;
            cliente.EnableSsl = true;
            */

            cliente.Host = "infratec.com"; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //Aquí gestionamos los errores al intentar enviar el correo
            }
        }

        public static void prueba4()
        {
            string EmailAddress = "jsphvega01@gmail.com";
            MailMessage mailMessage = new MailMessage(EmailAddress, EmailAddress);
            mailMessage.Subject = "This is a test email";
            mailMessage.Body = "This is a test email. Please reply if you receive it.";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = EmailAddress,
                Password = "Jsphvega1995"
            };
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Send(mailMessage);
        }

        static void Main(string[] args)
        {
            prueba4();
        }
    }
}
