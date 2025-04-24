using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMP_Proiect_3
{
    public partial class ModificareParola : Form
    {
        private SQLiteConnection conn = null;

        private Accounts user;

        string introducetiparolaActuala;
        string parolaActualaIncorecta;
        string parolaNouaInvalida;
        string parolaModificataCuSucces;
        public ModificareParola(Accounts user, string limba)
        {
            InitializeComponent();

            this.conn = SQLiteHandler.SQLiteConnect();

            this.user = user;

            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();
        }


        private void ApplyTranslation() 
        {
            labelParolaActuala.Text = Languages.Limba.labelParolaActuala;
            labelParolaNoua.Text = Languages.Limba.labelParolaNoua;
            btnModificaParola.Text = Languages.Limba.btnModificaNume;
            introducetiparolaActuala = Languages.Limba.introducetiparolaActuala;
            parolaActualaIncorecta = Languages.Limba.parolaActualaIncorecta;
            parolaNouaInvalida = Languages.Limba.parolaNouaInvalida;
            parolaModificataCuSucces = Languages.Limba.parolaModificataCuSucces;
        }
        private void btnModificaParola_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxParolaActuala.Text))
            {
                string parolaActuala = SQLiteHandler.GetPassword(conn, user.Username);

                SHA256 sha256 = SHA256.Create();

                byte[] input = Encoding.UTF8.GetBytes(textBoxParolaActuala.Text);

                byte[] hash = sha256.ComputeHash(input);

                StringBuilder sb = new StringBuilder();

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                String parolaHash = sb.ToString();

                if (parolaHash.Equals(parolaActuala))
                {
                    //Verificarea parolei noi si modificarea ei
                    if (!string.IsNullOrWhiteSpace(textBoxParolaNoua.Text))
                    {
                        SHA256 sha256_1 = SHA256.Create();

                        byte[] input1 = Encoding.UTF8.GetBytes(textBoxParolaNoua.Text);

                        byte[] hash1 = sha256_1.ComputeHash(input1);

                        StringBuilder sb1 = new StringBuilder();
                        foreach (byte b1 in hash1)
                        {
                            sb1.Append(b1.ToString("x2"));
                        }

                        string parolaNoua = sb1.ToString();
                        SQLiteHandler.ModificaPassword(conn, user.Username, parolaNoua);
                        MessageBox.Show(parolaModificataCuSucces);
                        this.Close();
                    }
                    else { MessageBox.Show(parolaNouaInvalida); }

                }
                else
                {
                    MessageBox.Show(parolaActualaIncorecta);
                }
            }
            else { MessageBox.Show(introducetiparolaActuala); }
        }
    }
}
