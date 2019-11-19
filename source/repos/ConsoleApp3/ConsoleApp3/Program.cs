    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("elijah.a.allen@gmail.com");
                mailMessage.From = new MailAddress("elijah.a.allen@gmail.com");
                mailMessage.Subject = "ASP.NET e-mail test";
                mailMessage.Body = "Hello world,\n\nThis is an ASP.NET test e-mail!";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Send(mailMessage);
                Console.Write("E-mail sent!");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.Write("Could not send the e-mail - error: " + ex.Message);
                Console.Read();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("elijah.a.allen@gmail.com");
                mailMessage.From = new MailAddress("elijah.a.allen@gmail.com" +
                    "");
                mailMessage.Subject = "ASP.NET e-mail test";
                mailMessage.Body = "Hello world,\n\nThis is an ASP.NET test e-mail!";
                SmtpClient smtpClient = new SmtpClient("smtp.your-isp.com");
                smtpClient.Send(mailMessage);
                Console.Write("E-mail sent!");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.Write("Could not send the e-mail - error: " + ex.Message);
                Console.Read();
            }
        }
    }
}
