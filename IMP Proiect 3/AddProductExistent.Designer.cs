namespace IMP_Proiect_3
{
    partial class AddProductExistent
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
            this.labelCantitate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericCantitate = new System.Windows.Forms.NumericUpDown();
            this.numericIdSelect = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(148, 196);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(110, 25);
            this.labelCantitate.TabIndex = 1;
            this.labelCantitate.Text = "Cantitate :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(303, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 59);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddCantitate);
            // 
            // numericCantitate
            // 
            this.numericCantitate.Location = new System.Drawing.Point(303, 196);
            this.numericCantitate.Name = "numericCantitate";
            this.numericCantitate.Size = new System.Drawing.Size(193, 31);
            this.numericCantitate.TabIndex = 5;
            // 
            // numericIdSelect
            // 
            this.numericIdSelect.Location = new System.Drawing.Point(303, 106);
            this.numericIdSelect.Name = "numericIdSelect";
            this.numericIdSelect.Size = new System.Drawing.Size(193, 31);
            this.numericIdSelect.TabIndex = 6;
            // 
            // AddProductExistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericIdSelect);
            this.Controls.Add(this.numericCantitate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.label1);
            this.Name = "AddProductExistent";
            this.Text = "AddProductExistent";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericCantitate;
        private System.Windows.Forms.NumericUpDown numericIdSelect;
    }
}