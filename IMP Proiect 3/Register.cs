using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using Languages;

using System.Security.Cryptography; 

namespace IMP_Proiect_3
{
    public partial class Register : Form
    {
        private SQLiteConnection conn = null;

        string contCreat;
        string usernameExistent;
        string parolaInvalida;
        string usernameInvalid;
        string prenumeInvalid;
        string numeInvalid;
        public Register(string limba)
        {
            InitializeComponent();

            conn = SQLiteHandler.SQLiteConnect();

            Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo(limba);

            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            labelRegister.Text = Languages.Limba.labelRegister;
            labelNume.Text = Languages.Limba.labelNume;
            labelPrenume.Text = Languages.Limba.labelPrenume;
            labelUsername.Text = Languages.Limba.labelUsername;
            labelPassword.Text = Languages.Limba.labelPassword;
            checkBoxAdminAccount.Text = Languages.Limba.checkBoxAdminAccount;
            btnRegister.Text = Languages.Limba.btnRegister;
            contCreat=Languages.Limba.contCreat;
            usernameExistent=Languages.Limba.usernameExistent;
            parolaInvalida = Languages.Limba.parolaInvalida;
            usernameInvalid=Languages.Limba.usernameInvalid;
            prenumeInvalid=Languages.Limba.prenumeInvalid;
            numeInvalid=Languages.Limba.numeInvalid;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (AccountsDBContext dbc = new AccountsDBContext())
            {
                Accounts a = new Accounts();
                a.Nume = textBoxNume.Text;
                a.Prenume = textBoxPrenume.Text;
                a.Username = textBoxUsername.Text;
                a.Password = textBoxPassword.Text; // lasam si linia asta ca metoda sa verifice mai intai daca parola e valida
                
                
                if (checkBoxAdminAccount.Checked)
                {
                    a.Administrator = 1;
                }
                else 
                {
                    a.Administrator = 0;
                }

                if (!string.IsNullOrWhiteSpace(a.Nume))
                {
                    if (!string.IsNullOrWhiteSpace(a.Prenume))
                    {
                        if (!string.IsNullOrWhiteSpace(a.Username))
                        {
                            if (!string.IsNullOrWhiteSpace(a.Password))
                            {
                                bool username = true;
                                username=SQLiteHandler.ValidateUsername(conn, a.Username);

                                if (username == false)
                                {
                                    //pana aici se verifica daca username-ul e unic

                                    SHA256 sha256 = SHA256.Create();

                                    byte[] input = Encoding.UTF8.GetBytes(textBoxPassword.Text);

                                    byte[] hash = sha256.ComputeHash(input);

                                    StringBuilder sb = new StringBuilder();
                                    foreach (byte b in hash)
                                    {
                                        sb.Append(b.ToString("x2"));
                                    }

                                    a.Password = sb.ToString();
                                    //pana aici codul hash-uieste parola

                                    dbc.Account.Add(a);
                                    dbc.SaveChanges();
                                    MessageBox.Show(contCreat);
                                    this.Close();

                                } else { MessageBox.Show(usernameExistent); }
                            }
                            else { MessageBox.Show(parolaInvalida); }
                        }
                        else { MessageBox.Show(usernameInvalid); }
                    }
                    else { MessageBox.Show(prenumeInvalid); }
                }
                else { MessageBox.Show(numeInvalid); }
            }
        }
    }
}
