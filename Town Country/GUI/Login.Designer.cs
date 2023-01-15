namespace Town_Country.GUI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btngoogle = new System.Windows.Forms.Button();
            this.btnfacebook = new System.Windows.Forms.Button();
            this.btnapple = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
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
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log in ";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusername.Location = new System.Drawing.Point(12, 111);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "User Name";
            this.txtusername.Size = new System.Drawing.Size(332, 33);
            this.txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpassword.Location = new System.Drawing.Point(12, 161);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.Size = new System.Drawing.Size(332, 33);
            this.txtpassword.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(244, 283);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 19);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Foget Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Remember Me ? ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.Location = new System.Drawing.Point(20, 238);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(305, 42);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(3, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 3);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "OR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(184, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 3);
            this.panel2.TabIndex = 9;
            // 
            // btngoogle
            // 
            this.btngoogle.BackgroundImage = global::Town_Country.Properties.Resources.google_symbol;
            this.btngoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngoogle.FlatAppearance.BorderSize = 0;
            this.btngoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoogle.Location = new System.Drawing.Point(29, 320);
            this.btngoogle.Name = "btngoogle";
            this.btngoogle.Size = new System.Drawing.Size(61, 56);
            this.btngoogle.TabIndex = 10;
            this.btngoogle.UseVisualStyleBackColor = true;
            // 
            // btnfacebook
            // 
            this.btnfacebook.BackgroundImage = global::Town_Country.Properties.Resources.facebook;
            this.btnfacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfacebook.FlatAppearance.BorderSize = 0;
            this.btnfacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacebook.Location = new System.Drawing.Point(131, 322);
            this.btnfacebook.Name = "btnfacebook";
            this.btnfacebook.Size = new System.Drawing.Size(75, 54);
            this.btnfacebook.TabIndex = 11;
            this.btnfacebook.UseVisualStyleBackColor = true;
            // 
            // btnapple
            // 
            this.btnapple.BackgroundImage = global::Town_Country.Properties.Resources.apple;
            this.btnapple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnapple.FlatAppearance.BorderSize = 0;
            this.btnapple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapple.Location = new System.Drawing.Point(244, 322);
            this.btnapple.Name = "btnapple";
            this.btnapple.Size = new System.Drawing.Size(75, 54);
            this.btnapple.TabIndex = 12;
            this.btnapple.UseVisualStyleBackColor = true;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Transparent;
            this.btnregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregister.Location = new System.Drawing.Point(131, 393);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 13;
            this.btnregister.Text = "Or SIGN UP ";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(356, 428);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnapple);
            this.Controls.Add(this.btnfacebook);
            this.Controls.Add(this.btngoogle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Log_in";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtusername;
        private TextBox txtpassword;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button btnlogin;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btngoogle;
        private Button btnfacebook;
        private Button btnapple;
        private Button btnregister;
    }
}