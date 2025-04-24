namespace IMP_Proiect_3
{
    partial class ModificareNume
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
            this.labelNumeNou = new System.Windows.Forms.Label();
            this.btnModificaNume = new System.Windows.Forms.Button();
            this.textBoxNumeNou = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNumeNou
            // 
            this.labelNumeNou.AutoSize = true;
            this.labelNumeNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumeNou.Location = new System.Drawing.Point(53, 149);
            this.labelNumeNou.Name = "labelNumeNou";
            this.labelNumeNou.Size = new System.Drawing.Size(302, 31);
            this.labelNumeNou.TabIndex = 0;
            this.labelNumeNou.Text = "Introduceti Nume nou:";
            // 
            // btnModificaNume
            // 
            this.btnModificaNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificaNume.Location = new System.Drawing.Point(253, 267);
            this.btnModificaNume.Name = "btnModificaNume";
            this.btnModificaNume.Size = new System.Drawing.Size(265, 69);
            this.btnModificaNume.TabIndex = 1;
            this.btnModificaNume.Text = "Modifica";
            this.btnModificaNume.UseVisualStyleBackColor = true;
            this.btnModificaNume.Click += new System.EventHandler(this.btnModificaNume_Click);
            // 
            // textBoxNumeNou
            // 
            this.textBoxNumeNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumeNou.Location = new System.Drawing.Point(385, 146);
            this.textBoxNumeNou.Name = "textBoxNumeNou";
            this.textBoxNumeNou.Size = new System.Drawing.Size(314, 38);
            this.textBoxNumeNou.TabIndex = 2;
            // 
            // ModificareNume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNumeNou);
            this.Controls.Add(this.btnModificaNume);
            this.Controls.Add(this.labelNumeNou);
            this.Name = "ModificareNume";
            this.Text = "ModificareNume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeNou;
        private System.Windows.Forms.Button btnModificaNume;
        private System.Windows.Forms.TextBox textBoxNumeNou;
    }
}