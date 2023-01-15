namespace Town_Country
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelApp = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttondeals = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrealestate = new System.Windows.Forms.Button();
            this.lbluserprofile = new System.Windows.Forms.Label();
            this.btnuserprofile = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnsignup);
            this.panelHeader.Controls.Add(this.btnlogin);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(804, 86);
            this.panelHeader.TabIndex = 0;
            // 
            // btnsignup
            // 
            this.btnsignup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsignup.Location = new System.Drawing.Point(716, 11);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 3;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnlogin.Location = new System.Drawing.Point(716, 56);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Log In ";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Town_Country.Properties.Resources.batman_logo;
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "real estate office";
            // 
            // panelApp
            // 
            this.panelApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApp.Controls.Add(this.btnexit);
            this.panelApp.Controls.Add(this.lbluser);
            this.panelApp.Controls.Add(this.pictureBox1);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApp.Location = new System.Drawing.Point(0, 86);
            this.panelApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(804, 85);
            this.panelApp.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackgroundImage = global::Town_Country.Properties.Resources.logout;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(748, 27);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(51, 51);
            this.btnexit.TabIndex = 2;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(103, 27);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(41, 16);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Town_Country.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Town_Country.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.label4);
            this.panelNavigation.Controls.Add(this.buttondeals);
            this.panelNavigation.Controls.Add(this.label3);
            this.panelNavigation.Controls.Add(this.btnrealestate);
            this.panelNavigation.Controls.Add(this.lbluserprofile);
            this.panelNavigation.Controls.Add(this.btnuserprofile);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 171);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(159, 359);
            this.panelNavigation.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(49, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Payment";
            // 
            // buttondeals
            // 
            this.buttondeals.BackColor = System.Drawing.Color.Transparent;
            this.buttondeals.BackgroundImage = global::Town_Country.Properties.Resources.handshake;
            this.buttondeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttondeals.FlatAppearance.BorderSize = 0;
            this.buttondeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondeals.Location = new System.Drawing.Point(38, 225);
            this.buttondeals.Name = "buttondeals";
            this.buttondeals.Size = new System.Drawing.Size(86, 83);
            this.buttondeals.TabIndex = 4;
            this.buttondeals.UseVisualStyleBackColor = false;
            this.buttondeals.Click += new System.EventHandler(this.buttondeals_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Real Estates";
            // 
            // btnrealestate
            // 
            this.btnrealestate.BackColor = System.Drawing.Color.Transparent;
            this.btnrealestate.BackgroundImage = global::Town_Country.Properties.Resources.property;
            this.btnrealestate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrealestate.FlatAppearance.BorderSize = 0;
            this.btnrealestate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrealestate.Location = new System.Drawing.Point(38, 117);
            this.btnrealestate.Name = "btnrealestate";
            this.btnrealestate.Size = new System.Drawing.Size(86, 86);
            this.btnrealestate.TabIndex = 2;
            this.btnrealestate.UseVisualStyleBackColor = false;
            this.btnrealestate.Click += new System.EventHandler(this.btnrealestate_Click);
            // 
            // lbluserprofile
            // 
            this.lbluserprofile.AutoSize = true;
            this.lbluserprofile.Location = new System.Drawing.Point(29, 89);
            this.lbluserprofile.Name = "lbluserprofile";
            this.lbluserprofile.Size = new System.Drawing.Size(95, 16);
            this.lbluserprofile.TabIndex = 1;
            this.lbluserprofile.Text = "User Profile";
            // 
            // btnuserprofile
            // 
            this.btnuserprofile.BackColor = System.Drawing.Color.Transparent;
            this.btnuserprofile.BackgroundImage = global::Town_Country.Properties.Resources.user;
            this.btnuserprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnuserprofile.FlatAppearance.BorderSize = 0;
            this.btnuserprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserprofile.Location = new System.Drawing.Point(38, 5);
            this.btnuserprofile.Name = "btnuserprofile";
            this.btnuserprofile.Size = new System.Drawing.Size(86, 81);
            this.btnuserprofile.TabIndex = 0;
            this.btnuserprofile.UseVisualStyleBackColor = false;
            this.btnuserprofile.Click += new System.EventHandler(this.buttonuserprofile_Click);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(159, 171);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(645, 359);
            this.panelContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 530);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Real Estates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Panel panelApp;
        private Panel panelNavigation;
        private Panel panelContent;
        private Label label1;
        private Button btnexit;
        private Label lbluser;
        private PictureBox pictureBox1;
        private Label label4;
        private Button buttondeals;
        private Label label3;
        private Button btnrealestate;
        private Label lbluserprofile;
        private Button btnuserprofile;
        private PictureBox pictureBox2;
        private Button btnlogin;
        private Button btnsignup;
    }
}