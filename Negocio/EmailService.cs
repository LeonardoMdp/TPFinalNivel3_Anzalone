using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;


namespace Negocio
{

    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public EmailService ()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("4a4be0e88f4cee", "ac959999b3550f");
            server.EnableSsl = true;
            server.Port = 2525;
            server.Host = "sandbox.smtp.mailtrap.io";
        }

        public void armarCorreo(string emaildestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@E-comerceCurlyRocker.com");
            email.To.Add(emaildestino);
            email.Subject = asunto;
            email.IsBodyHtml = true;
            email.Body = cuerpo;
        }

        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
