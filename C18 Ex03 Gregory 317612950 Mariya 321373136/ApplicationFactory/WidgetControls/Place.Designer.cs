namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    partial class Place
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
            this.PlaceImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlaceName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaceImage
            // 
            this.PlaceImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlaceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaceImage.Location = new System.Drawing.Point(0, 0);
            this.PlaceImage.Name = "PlaceImage";
            this.PlaceImage.Size = new System.Drawing.Size(120, 120);
            this.PlaceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlaceImage.TabIndex = 2;
            this.PlaceImage.TabStop = false;
            this.PlaceImage.Click += new System.EventHandler(this.PlaceImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlaceImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 3;
            // 
            // PlaceName
            // 
            this.PlaceName.AutoSize = true;
            this.PlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PlaceName.Location = new System.Drawing.Point(3, 123);
            this.PlaceName.Name = "PlaceName";
            this.PlaceName.Size = new System.Drawing.Size(35, 13);
            this.PlaceName.TabIndex = 4;
            this.PlaceName.Text = "label1";
            // 
            // Place
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlaceName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "Place";
            this.Size = new System.Drawing.Size(120, 140);
            ((System.ComponentModel.ISupportInitialize)(this.PlaceImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlaceImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PlaceName;
    }
}
