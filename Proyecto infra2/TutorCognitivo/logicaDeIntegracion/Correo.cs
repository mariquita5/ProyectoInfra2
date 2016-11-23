using System;
using System.Net.Mail;

namespace logicaDeIntegracion
{
    //clase para enviar correos
    public class Correo : ICorreo
    {
        private String asunto;
        private String cuerpoCorreo;
        private String correo;

        
        public Correo(String pAsunto, String pCuerpoCorreo, String pCorreo)
        {
            asunto = pAsunto;
            cuerpoCorreo = pCuerpoCorreo;
            correo = pCorreo;
        }

        //metodo que permite enviar un correo.
        public void enviarCorreo()
        {
            if (String.IsNullOrEmpty(correo))
                return;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("tutorcognitivo4@gmail.com", "Tutor Cognitivo by ChukyBueno");
                mail.Subject = asunto;

                mail.Body = cuerpoCorreo;

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; 
                smtp.Credentials = new System.Net.NetworkCredential
                     ("tutorcognitivo4@gmail.com", "chukyBueno4"); 
                smtp.Port = 587;
                
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception)
            {
            }
        }
    }
}