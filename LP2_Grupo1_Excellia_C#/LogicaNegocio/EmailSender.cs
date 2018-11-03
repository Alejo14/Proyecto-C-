using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace LogicaNegocio
{
    public class EmailSender
    {
        public static int enviarEmail(string emailReceptor, string asunto, string mensaje) {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("grupo1.lp2.20182@gmail.com");
                mail.To.Add(emailReceptor);
                mail.Subject = asunto;
                mail.Body = mensaje;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("grupo1.lp2.20182@gmail.com", "arribagrupo12018");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                return 0;
            }
            catch
            {
                return -1;
            }
        }
    }
}
