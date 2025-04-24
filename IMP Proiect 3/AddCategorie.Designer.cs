namespace IMP_Proiect_3
{
    partial class AddCategorie
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Categorie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adaugare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_AddCategorie);
            // 
            // textBox_Categorie
            // 
            this.textBox_Categorie.Location = new System.Drawing.Point(229, 82);
            this.textBox_Categorie.Name = "textBox_Categorie";
            this.textBox_Categorie.Size = new System.Drawing.Size(282, 31);
            this.textBox_Categorie.TabIndex = 2;
            // 
            // AddCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 310);
            this.Controls.Add(this.textBox_Categorie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AddCategorie";
            this.Text = "AddCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Categorie;
    }
}