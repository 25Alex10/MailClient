using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            Console.WriteLine("Введите Ваш логин: ");
            string userlogin = Console.ReadLine();
            Console.WriteLine("Введите Ваш пароль: ");
            string userpassword = Console.ReadLine();
            smtp.Credentials = new NetworkCredential(userlogin, userpassword);
            MailAddress from = new MailAddress(userlogin, "Boss");
            Console.WriteLine("Введите e-mail-адрес получателя:");
            string recipientadress = Console.ReadLine();
            MailAddress to = new MailAddress(recipientadress);
            MailMessage messagel = new MailMessage(from, to);
            messagel.Subject = "Hide";
            messagel.Body = "<h2>Hello</h2>";
            messagel.IsBodyHtml = true;
            smtp.EnableSsl = true;
            smtp.Send(messagel);
            Console.ReadLine();
        }
    }
}