﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ticariotomasyon
{
    public partial class frmmail : Form
    {
        public frmmail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frmmail_Load(object sender, EventArgs e)
        {
            txtmail.Text = mail;
        }

        private void sbtngonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("ikinoktasifir35@gmail.com", "tr4k0ny4gm1");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(txtmail.Text);
            mesajim.From = new MailAddress("ikinoktasifir35@gmail.com");
            mesajim.Subject = txtkonu.Text;
            mesajim.Body = txtmesaj.Text;
            istemci.Send(mesajim);
        }
    }
}
