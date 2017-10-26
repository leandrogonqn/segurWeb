using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;


namespace Dominio
{
    public class Email
    {
        public Email()
        {

        }

        public void enviarMail(
            String emisor,
            String receptor,
            String asunto,
            String mensaj)
        {
            string servidor = "smtp.gmail.com";
            MailMessage mensaje = new MailMessage(
               emisor,
               receptor,
               asunto,
               mensaj);

            //Envía el mensaje.
            SmtpClient cliente = new SmtpClient(servidor);

            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential("sistemasigese@gmail.com", "Pacinete1234");
            cliente.Port = 587;
            cliente.Host = "smtp.gmail.com";
            cliente.EnableSsl = true;

            cliente.Send(mensaje);
        }
    }
}
