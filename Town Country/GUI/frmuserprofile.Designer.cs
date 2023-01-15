namespace Town_Country.GUI
{
    partial class frmuserprofile
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
            this.pibxuserprofile = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibxuserprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // pibxuserprofile
            // 
            this.pibxuserprofile.BackgroundImage = global::Town_Country.Properties.Resources.user;
            this.pibxuserprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pibxuserprofile.Location = new System.Drawing.Point(14, 14);
            this.pibxuserprofile.Margin = new System.Windows.Forms.Padding(5);
            this.pibxuserprofile.Name = "pibxuserprofile";
            this.pibxuserprofile.Size = new System.Drawing.Size(158, 111);
            this.pibxuserprofile.TabIndex = 0;
            this.pibxuserprofile.TabStop = false;
            this.pibxuserprofile.Click += new System.EventHandler(this.pibxuserprofile_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 161);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(109, 21);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Your Name :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtname.Location = new System.Drawing.Point(12, 189);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(127, 24);
            this.txtname.TabIndex = 2;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(12, 233);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(154, 21);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "Your User Name :";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtusername.Location = new System.Drawing.Point(12, 257);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(127, 24);
            this.txtusername.TabIndex = 4;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(12, 294);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(118, 21);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Your Email :";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtemail.Location = new System.Drawing.Point(12, 318);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(154, 24);
            this.txtemail.TabIndex = 6;
            // 
            // frmuserprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(337, 368);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pibxuserprofile);
            this.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmuserprofile";
            this.Text = "frmuserprofile";
            this.Load += new System.EventHandler(this.frmuserprofile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibxuserprofile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pibxuserprofile;
        private Label lblname;
        private TextBox txtname;
        private Label lblusername;
        private TextBox txtusername;
        private Label lblemail;
        private TextBox txtemail;
    }
}