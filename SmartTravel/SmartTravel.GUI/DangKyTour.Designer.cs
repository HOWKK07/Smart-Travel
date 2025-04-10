namespace SmartTravel.GUI
{
    partial class DangKyTour
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbGmail = new System.Windows.Forms.Label();
            this.GBoxTTLH = new System.Windows.Forms.GroupBox();
            this.tbGmail = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.GBoxTTLH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(17, 31);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(43, 13);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(234, 31);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(70, 13);
            this.lbSDT.TabIndex = 2;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbGmail
            // 
            this.lbGmail.AutoSize = true;
            this.lbGmail.Location = new System.Drawing.Point(453, 31);
            this.lbGmail.Name = "lbGmail";
            this.lbGmail.Size = new System.Drawing.Size(33, 13);
            this.lbGmail.TabIndex = 3;
            this.lbGmail.Text = "Gmail";
            // 
            // GBoxTTLH
            // 
            this.GBoxTTLH.Controls.Add(this.tbGmail);
            this.GBoxTTLH.Controls.Add(this.tbSDT);
            this.GBoxTTLH.Controls.Add(this.tbHoTen);
            this.GBoxTTLH.Controls.Add(this.lbGmail);
            this.GBoxTTLH.Controls.Add(this.lbHoTen);
            this.GBoxTTLH.Controls.Add(this.lbSDT);
            this.GBoxTTLH.Location = new System.Drawing.Point(40, 17);
            this.GBoxTTLH.Name = "GBoxTTLH";
            this.GBoxTTLH.Size = new System.Drawing.Size(686, 96);
            this.GBoxTTLH.TabIndex = 4;
            this.GBoxTTLH.TabStop = false;
            this.GBoxTTLH.Text = "Thông tin liên hệ";
            this.GBoxTTLH.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbGmail
            // 
            this.tbGmail.Location = new System.Drawing.Point(456, 47);
            this.tbGmail.Name = "tbGmail";
            this.tbGmail.Size = new System.Drawing.Size(181, 20);
            this.tbGmail.TabIndex = 5;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(237, 47);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(181, 20);
            this.tbSDT.TabIndex = 5;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(20, 47);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(181, 20);
            this.tbHoTen.TabIndex = 4;
            this.tbHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(496, 458);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 23);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Đăng ký";
            // 
            // DangKyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 493);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.GBoxTTLH);
            this.Name = "DangKyTour";
            this.Text = "DangKyTour";
            this.Load += new System.EventHandler(this.DangKyTour_Load);
            this.GBoxTTLH.ResumeLayout(false);
            this.GBoxTTLH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbGmail;
        private System.Windows.Forms.GroupBox GBoxTTLH;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbGmail;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Button buttonRegister;
    }
}