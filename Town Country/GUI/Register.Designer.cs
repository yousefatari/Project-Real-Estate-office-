namespace Town_Country.GUI
{
    partial class Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblregister = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.txtcppass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Town_Country.Properties.Resources.batman_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.BackColor = System.Drawing.Color.Transparent;
            this.lblregister.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblregister.Location = new System.Drawing.Point(142, 41);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(110, 32);
            this.lblregister.TabIndex = 1;
            this.lblregister.Text = "SIGN UP";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(87, 111);
            this.txtname.Name = "txtname";
            this.txtname.PlaceholderText = "Name";
            this.txtname.Size = new System.Drawing.Size(187, 23);
            this.txtname.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(87, 153);
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "User Name";
            this.txtusername.Size = new System.Drawing.Size(187, 23);
            this.txtusername.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(87, 197);
            this.txtemail.Name = "txtemail";
            this.txtemail.PlaceholderText = "EMAIL";
            this.txtemail.Size = new System.Drawing.Size(187, 23);
            this.txtemail.TabIndex = 4;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(87, 242);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.Size = new System.Drawing.Size(187, 23);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "I agree all the staement in \r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.Thistle;
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsignup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsignup.Location = new System.Drawing.Point(274, 320);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 32);
            this.btnsignup.TabIndex = 7;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // txtcppass
            // 
            this.txtcppass.Location = new System.Drawing.Point(87, 291);
            this.txtcppass.Name = "txtcppass";
            this.txtcppass.PlaceholderText = "confirm Password";
            this.txtcppass.Size = new System.Drawing.Size(187, 23);
            this.txtcppass.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(374, 364);
            this.Controls.Add(this.txtcppass);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblregister);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblregister;
        private TextBox txtname;
        private TextBox txtusername;
        private TextBox txtemail;
        private TextBox txtpassword;
        private CheckBox checkBox1;
        private Button btnsignup;
        private TextBox txtcppass;
    }
}