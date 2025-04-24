namespace IMP_Proiect_3
{
    partial class ModificareParola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxParolaNoua = new System.Windows.Forms.TextBox();
            this.btnModificaParola = new System.Windows.Forms.Button();
            this.labelParolaNoua = new System.Windows.Forms.Label();
            this.textBoxParolaActuala = new System.Windows.Forms.TextBox();
            this.labelParolaActuala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxParolaNoua
            // 
            this.textBoxParolaNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxParolaNoua.Location = new System.Drawing.Point(350, 210);
            this.textBoxParolaNoua.Name = "textBoxParolaNoua";
            this.textBoxParolaNoua.Size = new System.Drawing.Size(314, 38);
            this.textBoxParolaNoua.TabIndex = 8;
            // 
            // btnModificaParola
            // 
            this.btnModificaParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificaParola.Location = new System.Drawing.Point(262, 304);
            this.btnModificaParola.Name = "btnModificaParola";
            this.btnModificaParola.Size = new System.Drawing.Size(265, 69);
            this.btnModificaParola.TabIndex = 7;
            this.btnModificaParola.Text = "Modifica";
            this.btnModificaParola.UseVisualStyleBackColor = true;
            this.btnModificaParola.Click += new System.EventHandler(this.btnModificaParola_Click);
            // 
            // labelParolaNoua
            // 
            this.labelParolaNoua.AutoSize = true;
            this.labelParolaNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelParolaNoua.Location = new System.Drawing.Point(113, 213);
            this.labelParolaNoua.Name = "labelParolaNoua";
            this.labelParolaNoua.Size = new System.Drawing.Size(179, 31);
            this.labelParolaNoua.TabIndex = 6;
            this.labelParolaNoua.Text = "Parola noua:";
            // 
            // textBoxParolaActuala
            // 
            this.textBoxParolaActuala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxParolaActuala.Location = new System.Drawing.Point(350, 104);
            this.textBoxParolaActuala.Name = "textBoxParolaActuala";
            this.textBoxParolaActuala.Size = new System.Drawing.Size(314, 38);
            this.textBoxParolaActuala.TabIndex = 10;
            // 
            // labelParolaActuala
            // 
            this.labelParolaActuala.AutoSize = true;
            this.labelParolaActuala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelParolaActuala.Location = new System.Drawing.Point(82, 107);
            this.labelParolaActuala.Name = "labelParolaActuala";
            this.labelParolaActuala.Size = new System.Drawing.Size(210, 31);
            this.labelParolaActuala.TabIndex = 9;
            this.labelParolaActuala.Text = "Parola actuala:";
            // 
            // ModificareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxParolaActuala);
            this.Controls.Add(this.labelParolaActuala);
            this.Controls.Add(this.textBoxParolaNoua);
            this.Controls.Add(this.btnModificaParola);
            this.Controls.Add(this.labelParolaNoua);
            this.Name = "ModificareParola";
            this.Text = "ModificareParola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParolaNoua;
        private System.Windows.Forms.Button btnModificaParola;
        private System.Windows.Forms.Label labelParolaNoua;
        private System.Windows.Forms.TextBox textBoxParolaActuala;
        private System.Windows.Forms.Label labelParolaActuala;
    }
}