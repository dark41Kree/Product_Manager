namespace IMP_Proiect_3
{
    partial class ModificarePrenume
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
            this.textBoxPrenumeNou = new System.Windows.Forms.TextBox();
            this.btnModificaPrenume = new System.Windows.Forms.Button();
            this.labelPrenumeNou = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPrenumeNou
            // 
            this.textBoxPrenumeNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrenumeNou.Location = new System.Drawing.Point(433, 125);
            this.textBoxPrenumeNou.Name = "textBoxPrenumeNou";
            this.textBoxPrenumeNou.Size = new System.Drawing.Size(314, 38);
            this.textBoxPrenumeNou.TabIndex = 5;
            // 
            // btnModificaPrenume
            // 
            this.btnModificaPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificaPrenume.Location = new System.Drawing.Point(259, 251);
            this.btnModificaPrenume.Name = "btnModificaPrenume";
            this.btnModificaPrenume.Size = new System.Drawing.Size(265, 69);
            this.btnModificaPrenume.TabIndex = 4;
            this.btnModificaPrenume.Text = "Modifica";
            this.btnModificaPrenume.UseVisualStyleBackColor = true;
            this.btnModificaPrenume.Click += new System.EventHandler(this.btnModificaPrenume_Click);
            // 
            // labelPrenumeNou
            // 
            this.labelPrenumeNou.AutoSize = true;
            this.labelPrenumeNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrenumeNou.Location = new System.Drawing.Point(48, 128);
            this.labelPrenumeNou.Name = "labelPrenumeNou";
            this.labelPrenumeNou.Size = new System.Drawing.Size(342, 31);
            this.labelPrenumeNou.TabIndex = 3;
            this.labelPrenumeNou.Text = "Introduceti Prenume nou:";
            // 
            // ModificarePrenume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrenumeNou);
            this.Controls.Add(this.btnModificaPrenume);
            this.Controls.Add(this.labelPrenumeNou);
            this.Name = "ModificarePrenume";
            this.Text = "ModificarePrenume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrenumeNou;
        private System.Windows.Forms.Button btnModificaPrenume;
        private System.Windows.Forms.Label labelPrenumeNou;
    }
}