using mySMTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;

namespace NoSeQueHago
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage();
            mail.From = "admin@infratec.com";
            mail.To = "jvega@infratec.com";
            mail.Subject = "Prueba";
            mail.Body = "Hola luuuuuu";

            //SmtpDirect sm = new SmtpDirect();
            SmtpDirect.Send(mail);
        }
    }
}
