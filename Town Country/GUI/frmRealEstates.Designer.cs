namespace Town_Country.GUI
{
    partial class frmRealEstates
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRealEstates));
            this.tmrrent = new System.Windows.Forms.Timer(this.components);
            this.imglsrent = new System.Windows.Forms.ImageList(this.components);
            this.lbldetils = new System.Windows.Forms.Label();
            this.btnShowmore = new System.Windows.Forms.Button();
            this.picbx1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrrent
            // 
            this.tmrrent.Enabled = true;
            this.tmrrent.Interval = 3000;
            this.tmrrent.Tick += new System.EventHandler(this.tmrrent_Tick);
            // 
            // imglsrent
            // 
            this.imglsrent.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imglsrent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglsrent.ImageStream")));
            this.imglsrent.TransparentColor = System.Drawing.Color.Transparent;
            this.imglsrent.Images.SetKeyName(0, "home3.jpeg");
            this.imglsrent.Images.SetKeyName(1, "home2\\.jpg");
            this.imglsrent.Images.SetKeyName(2, "home1.jpg");
            // 
            // lbldetils
            // 
            this.lbldetils.AutoSize = true;
            this.lbldetils.BackColor = System.Drawing.Color.Bisque;
            this.lbldetils.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldetils.ForeColor = System.Drawing.Color.Black;
            this.lbldetils.Location = new System.Drawing.Point(294, 36);
            this.lbldetils.Name = "lbldetils";
            this.lbldetils.Size = new System.Drawing.Size(300, 180);
            this.lbldetils.TabIndex = 1;
            this.lbldetils.Text = "Homes for sale in :\r\nTabarbour\r\nAbdoun\r\nMarj Alhamam\r\n";
            // 
            // btnShowmore
            // 
            this.btnShowmore.BackColor = System.Drawing.Color.Transparent;
            this.btnShowmore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowmore.Location = new System.Drawing.Point(327, 240);
            this.btnShowmore.Name = "btnShowmore";
            this.btnShowmore.Size = new System.Drawing.Size(94, 28);
            this.btnShowmore.TabIndex = 2;
            this.btnShowmore.Text = "Show More";
            this.btnShowmore.UseVisualStyleBackColor = false;
            this.btnShowmore.Click += new System.EventHandler(this.btnShowmore_Click);
            // 
            // picbx1
            // 
            this.picbx1.Image = global::Town_Country.Properties.Resources.home12;
            this.picbx1.Location = new System.Drawing.Point(12, 36);
            this.picbx1.Name = "picbx1";
            this.picbx1.Size = new System.Drawing.Size(264, 180);
            this.picbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx1.TabIndex = 3;
            this.picbx1.TabStop = false;
            // 
            // frmRealEstates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(734, 355);
            this.Controls.Add(this.picbx1);
            this.Controls.Add(this.btnShowmore);
            this.Controls.Add(this.lbldetils);
            this.Name = "frmRealEstates";
            this.Text = "frmRealEstates";
            ((System.ComponentModel.ISupportInitialize)(this.picbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrrent;
        private ImageList imglsrent;
        private Label lbldetils;
        private Button btnShowmore;
        private PictureBox picbx1;
    }
}