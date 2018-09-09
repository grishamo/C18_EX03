namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    partial class Widget
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
            this.Title = new System.Windows.Forms.Label();
            this.WidgetContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(216, 18);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // WidgetContainer
            // 
            this.WidgetContainer.AutoSize = true;
            this.WidgetContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidgetContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidgetContainer.Location = new System.Drawing.Point(10, 33);
            this.WidgetContainer.Name = "WidgetContainer";
            this.WidgetContainer.Size = new System.Drawing.Size(367, 212);
            this.WidgetContainer.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Title);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 23);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WidgetContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Widget";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(387, 255);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected System.Windows.Forms.Label Title;
        public System.Windows.Forms.FlowLayoutPanel WidgetContainer;
    }
}
