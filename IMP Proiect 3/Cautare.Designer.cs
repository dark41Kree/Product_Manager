namespace IMP_Proiect_3
{
    partial class Cautare
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
            this.nUDID = new System.Windows.Forms.NumericUpDown();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelSelectId = new System.Windows.Forms.Label();
            this.btnCaut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDID
            // 
            this.nUDID.Location = new System.Drawing.Point(430, 90);
            this.nUDID.Name = "nUDID";
            this.nUDID.Size = new System.Drawing.Size(144, 31);
            this.nUDID.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.Location = new System.Drawing.Point(266, 157);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(500, 468);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "INFO:";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelInfo.UseCompatibleTextRendering = true;
            // 
            // labelSelectId
            // 
            this.labelSelectId.AutoSize = true;
            this.labelSelectId.Location = new System.Drawing.Point(291, 92);
            this.labelSelectId.Name = "labelSelectId";
            this.labelSelectId.Size = new System.Drawing.Size(133, 25);
            this.labelSelectId.TabIndex = 2;
            this.labelSelectId.Text = "Selectati ID :";
            // 
            // btnCaut
            // 
            this.btnCaut.Location = new System.Drawing.Point(587, 85);
            this.btnCaut.Name = "btnCaut";
            this.btnCaut.Size = new System.Drawing.Size(139, 39);
            this.btnCaut.TabIndex = 3;
            this.btnCaut.Text = "Search";
            this.btnCaut.UseVisualStyleBackColor = true;
            this.btnCaut.Click += new System.EventHandler(this.btnCaut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(412, 628);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Cautare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 712);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCaut);
            this.Controls.Add(this.labelSelectId);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.nUDID);
            this.Name = "Cautare";
            this.Text = "Cautare";
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDID;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelSelectId;
        private System.Windows.Forms.Button btnCaut;
        private System.Windows.Forms.Button btnClose;
    }
}