using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Languages;


namespace IMP_Proiect_3
{
    public partial class Login : Form
    {
        private SQLiteConnection conn = null;
        string ro = "ro";
        string en = "en";
        string limbaActuala;

        string introducetiUsername;
        string usernameInvalid;
        string introducetiParola;
        string parolaGresita;

        public Login()
        {
            InitializeComponent();

            conn = SQLiteHandler.SQLiteConnect();

            Thread.CurrentThread.CurrentUICulture =
    new System.Globalization.CultureInfo(en);
            limbaActuala = en;

            ApplyTranslation();


        }

        // Async task-ul sa returneze informatia nu direct in datagridview, ci poate
        //intr-o variabila. doar sa nu returneze direct informatia in firul principal!!!
        private void ApplyTranslation()
        {
            btnLogin.Text = Languages.Limba.btnLogin;
            label1.Text = Languages.Limba.label1;
            labelPassword.Text = Languages.Limba.labelPassword;
            labelUsername.Text = Languages.Limba.labelUsername;
            linkLabel1.Text = Languages.Limba.linkLabel1;
            optionsToolStripMenuItem.Text = Languages.Limba.optionsToolStripMenuItem;
            languageToolStripMenuItem.Text = Languages.Limba.languageToolStripMenuItem;
            romanianToolStripMenuItem.Text = Languages.Limba.romanianToolStripMenuItem;
            englishToolStripMenuItem.Text = Languages.Limba.englishToolStripMenuItem;
            introducetiUsername=Languages.Limba.introducetiUsername;
            usernameInvalid = Languages.Limba.usernameInvalid;
            introducetiParola = Languages.Limba.introducetiParola;
            parolaGresita = Languages.Limba.parolaGresita;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register(limbaActuala);
            rg.ShowDialog();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                if (SQLiteHandler.ValidateUsername(conn, textBoxUsername.Text))
                {
                    if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
                    {
                        string passDinDB = SQLiteHandler.GetPassword(conn, textBoxUsername.Text);

                        SHA256 sha256 = SHA256.Create();

                        byte[] input = Encoding.UTF8.GetBytes(textBoxPassword.Text);

                        byte[] hash = sha256.ComputeHash(input);

                        StringBuilder sb = new StringBuilder();

                        foreach (byte b in hash)
                        {
                            sb.Append(b.ToString("x2"));
                        }

                        String parolaHash = sb.ToString();

                        if (parolaHash.Equals(passDinDB))
                        {
                            Accounts user = SQLiteHandler.GetUserInfo(conn, textBoxUsername.Text);
                            DatabaseManager db1 = new DatabaseManager(user,limbaActuala);
                            db1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(parolaGresita);
                        }

                    }
                    else { MessageBox.Show(introducetiParola); }

                }
                else { MessageBox.Show(usernameInvalid); }
            }
            else { MessageBox.Show(introducetiUsername); }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(en);

            ApplyTranslation();
            limbaActuala = en;
        }

        private void romanianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(ro);

            ApplyTranslation();
            limbaActuala = ro;
        }
    }
}
