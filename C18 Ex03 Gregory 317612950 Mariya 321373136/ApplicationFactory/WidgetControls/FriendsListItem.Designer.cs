namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    partial class FriendListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Userpic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Username = new System.Windows.Forms.Label();
            this.PlacesCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Userpic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Userpic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 29);
            this.panel1.TabIndex = 2;
            // 
            // Userpic
            // 
            this.Userpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Userpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Userpic.Location = new System.Drawing.Point(0, 0);
            this.Userpic.Name = "Userpic";
            this.Userpic.Size = new System.Drawing.Size(35, 29);
            this.Userpic.TabIndex = 2;
            this.Userpic.TabStop = false;
            this.Userpic.Click += new System.EventHandler(this.FriendItem_Click);
            this.Userpic.MouseEnter += new System.EventHandler(this.FriendListItem_MouseEnter);
            this.Userpic.MouseLeave += new System.EventHandler(this.FriendListItem_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Username, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlacesCount, 0, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 29);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.FriendItem_Click);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.FriendListItem_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.FriendListItem_MouseLeave);
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Username.AutoSize = true;
            this.Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.Username.Location = new System.Drawing.Point(0, 0);
            this.Username.Margin = new System.Windows.Forms.Padding(0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 14);
            this.Username.TabIndex = 0;
            this.Username.Text = "User Name";
            this.Username.Click += new System.EventHandler(this.FriendItem_Click);
            this.Username.MouseEnter += new System.EventHandler(this.FriendListItem_MouseEnter);
            this.Username.MouseLeave += new System.EventHandler(this.FriendListItem_MouseLeave);
            // 
            // PlacesCount
            // 
            this.PlacesCount.AutoSize = true;
            this.PlacesCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlacesCount.Enabled = false;
            this.PlacesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PlacesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlacesCount.Location = new System.Drawing.Point(0, 16);
            this.PlacesCount.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PlacesCount.Name = "PlacesCount";
            this.PlacesCount.Size = new System.Drawing.Size(54, 13);
            this.PlacesCount.TabIndex = 1;
            this.PlacesCount.Text = "15 Places";
            // 
            // FriendListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FriendListItem";
            this.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.Size = new System.Drawing.Size(268, 37);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Userpic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label PlacesCount;
        private System.Windows.Forms.PictureBox Userpic;
    }
}
