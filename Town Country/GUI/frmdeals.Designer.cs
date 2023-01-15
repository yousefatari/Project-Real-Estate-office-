namespace Town_Country.GUI
{
    partial class frmdeals
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtNophone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.btndeals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Town_Country.Properties.Resources.batman_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 149);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "User Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(116, 146);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 27);
            this.txtUsername.TabIndex = 3;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(12, 200);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(35, 18);
            this.lblJob.TabIndex = 4;
            this.lblJob.Text = "Job";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(115, 197);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(145, 27);
            this.txtJob.TabIndex = 5;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(12, 259);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(86, 18);
            this.lblphone.TabIndex = 6;
            this.lblphone.Text = "No.Phone";
            // 
            // txtNophone
            // 
            this.txtNophone.Location = new System.Drawing.Point(115, 256);
            this.txtNophone.Name = "txtNophone";
            this.txtNophone.Size = new System.Drawing.Size(145, 27);
            this.txtNophone.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment method";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(12, 374);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(98, 18);
            this.lblNationality.TabIndex = 9;
            this.lblNationality.Text = "Nationality";
            // 
            // cmbPay
            // 
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Items.AddRange(new object[] {
            "Cash",
            "By the Bank"});
            this.cmbPay.Location = new System.Drawing.Point(165, 314);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(144, 26);
            this.cmbPay.TabIndex = 10;
            // 
            // cmbNationality
            // 
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Items.AddRange(new object[] {
            "Jordanian",
            "Oman",
            "Usa",
            "Uk",
            "Sudan",
            "Saudi Arabia"});
            this.cmbNationality.Location = new System.Drawing.Point(117, 371);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(144, 26);
            this.cmbNationality.TabIndex = 10;
            // 
            // btndeals
            // 
            this.btndeals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeals.Location = new System.Drawing.Point(313, 432);
            this.btndeals.Name = "btndeals";
            this.btndeals.Size = new System.Drawing.Size(75, 32);
            this.btndeals.TabIndex = 11;
            this.btndeals.Text = "Order";
            this.btndeals.UseVisualStyleBackColor = true;
            this.btndeals.Click += new System.EventHandler(this.btndeals_Click);
            // 
            // frmdeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(400, 503);
            this.Controls.Add(this.btndeals);
            this.Controls.Add(this.cmbNationality);
            this.Controls.Add(this.cmbPay);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNophone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmdeals";
            this.Text = "frmdeals";
            this.Load += new System.EventHandler(this.frmdeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblJob;
        private TextBox txtJob;
        private Label lblphone;
        private TextBox txtNophone;
        private Label label2;
        private Label lblNationality;
        private ComboBox cmbPay;
        private ComboBox cmbNationality;
        private Button btndeals;
    }
}