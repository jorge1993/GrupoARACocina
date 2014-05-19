﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send_Click(object sender, EventArgs e)
        {
   
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();
            try
            {

                MailAddress fromAddress = new MailAddress(TextBox2.Text, TextBox1.Text);
                MailAddress toAddress = new MailAddress("kagonetti@gmail.com", "Alias destinatario");
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = TextBox3.Text;
                message.Body = TextBox4.Text;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(TextBox2.Text, TextBox21.Text);
                smtpClient.Send(message);
                Label1.Text = "Mensaje enviado.";

            }

            catch (Exception ex)
            {
                Label1.Text = "No se pudo enviar el mensaje!";

            }	
        }

        

               
    }
}