namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    partial class MainApplicationForm
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
            this.FbLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppIdLabel = new System.Windows.Forms.Label();
            this.AppIdComboBox = new System.Windows.Forms.ComboBox();
            this.MainText = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // FbLogin
            // 
            this.FbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.FbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FbLogin.ForeColor = System.Drawing.Color.White;
            this.FbLogin.Location = new System.Drawing.Point(76, 85);
            this.FbLogin.Name = "FbLogin";
            this.FbLogin.Size = new System.Drawing.Size(242, 69);
            this.FbLogin.TabIndex = 5;
            this.FbLogin.Text = "Signin To Facebook";
            this.FbLogin.UseVisualStyleBackColor = false;
            this.FbLogin.Click += new System.EventHandler(this.FbLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AppIdLabel);
            this.groupBox1.Controls.Add(this.AppIdComboBox);
            this.groupBox1.Controls.Add(this.MainText);
            this.groupBox1.Controls.Add(this.FbLogin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.groupBox1.Location = new System.Drawing.Point(292, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // AppIdLabel
            // 
            this.AppIdLabel.AutoSize = true;
            this.AppIdLabel.Location = new System.Drawing.Point(118, 173);
            this.AppIdLabel.Name = "AppIdLabel";
            this.AppIdLabel.Size = new System.Drawing.Size(44, 13);
            this.AppIdLabel.TabIndex = 10;
            this.AppIdLabel.Text = "App Id";
            // 
            // AppIdComboBox
            // 
            this.AppIdComboBox.FormattingEnabled = true;
            this.AppIdComboBox.Location = new System.Drawing.Point(172, 169);
            this.AppIdComboBox.Name = "AppIdComboBox";
            this.AppIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.AppIdComboBox.TabIndex = 9;
            this.AppIdComboBox.SelectedIndexChanged += new System.EventHandler(this.AppIdComboBox_SelectedIndexChanged);
            // 
            // MainText
            // 
            this.MainText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainText.AutoSize = true;
            this.MainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.MainText.Location = new System.Drawing.Point(50, 45);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(295, 25);
            this.MainText.TabIndex = 8;
            this.MainText.Text = "Find Your Next Place To Visit";
            this.MainText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignIn
            // 
            this.SignIn.Controls.Add(this.groupBox1);
            this.SignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignIn.Location = new System.Drawing.Point(0, 0);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(950, 701);
            this.SignIn.TabIndex = 8;
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 701);
            this.Controls.Add(this.SignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainApplicationForm";
            this.Text = "Faceplaces";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SignIn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FbLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel SignIn;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Label AppIdLabel;
        private System.Windows.Forms.ComboBox AppIdComboBox;
    }
}

