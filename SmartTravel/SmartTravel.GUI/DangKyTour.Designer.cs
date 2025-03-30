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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tour Văn Hoá"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Tour Nghỉ dưỡng");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Tour Sinh Thái");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Tour Mạo Hiểm");
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbGmail = new System.Windows.Forms.Label();
            this.GBoxTTLH = new System.Windows.Forms.GroupBox();
            this.tbGmail = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.gbTTTour = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSoLuongNguoi = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.cbMayBay = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTauHoa = new System.Windows.Forms.CheckBox();
            this.cbXeKhach = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.GBoxTTLH.SuspendLayout();
            this.gbTTTour.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // gbTTTour
            // 
            this.gbTTTour.Controls.Add(this.listView1);
            this.gbTTTour.Controls.Add(this.label2);
            this.gbTTTour.Controls.Add(this.dateTimePicker1);
            this.gbTTTour.Controls.Add(this.textBox1);
            this.gbTTTour.Controls.Add(this.textBox3);
            this.gbTTTour.Controls.Add(this.label1);
            this.gbTTTour.Controls.Add(this.lbSoLuongNguoi);
            this.gbTTTour.Controls.Add(this.lb);
            this.gbTTTour.Location = new System.Drawing.Point(40, 131);
            this.gbTTTour.Name = "gbTTTour";
            this.gbTTTour.Size = new System.Drawing.Size(686, 204);
            this.gbTTTour.TabIndex = 5;
            this.gbTTTour.TabStop = false;
            this.gbTTTour.Text = "Thông tin Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại Tour";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số ngày";
            // 
            // lbSoLuongNguoi
            // 
            this.lbSoLuongNguoi.AutoSize = true;
            this.lbSoLuongNguoi.Location = new System.Drawing.Point(74, 31);
            this.lbSoLuongNguoi.Name = "lbSoLuongNguoi";
            this.lbSoLuongNguoi.Size = new System.Drawing.Size(82, 13);
            this.lbSoLuongNguoi.TabIndex = 1;
            this.lbSoLuongNguoi.Text = "Số lượng khách";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(234, 31);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(82, 13);
            this.lb.TabIndex = 2;
            this.lb.Text = "Ngày khởi hành";
            this.lb.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbMayBay
            // 
            this.cbMayBay.AutoSize = true;
            this.cbMayBay.Location = new System.Drawing.Point(65, 35);
            this.cbMayBay.Name = "cbMayBay";
            this.cbMayBay.Size = new System.Drawing.Size(67, 17);
            this.cbMayBay.TabIndex = 8;
            this.cbMayBay.Text = "Máy Bay";
            this.cbMayBay.UseVisualStyleBackColor = true;
            this.cbMayBay.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbXeKhach);
            this.groupBox1.Controls.Add(this.cbTauHoa);
            this.groupBox1.Controls.Add(this.cbMayBay);
            this.groupBox1.Location = new System.Drawing.Point(40, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương tiện";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cbTauHoa
            // 
            this.cbTauHoa.AutoSize = true;
            this.cbTauHoa.Location = new System.Drawing.Point(237, 35);
            this.cbTauHoa.Name = "cbTauHoa";
            this.cbTauHoa.Size = new System.Drawing.Size(68, 17);
            this.cbTauHoa.TabIndex = 9;
            this.cbTauHoa.Text = "Tàu Hoả";
            this.cbTauHoa.UseVisualStyleBackColor = true;
            // 
            // cbXeKhach
            // 
            this.cbXeKhach.AutoSize = true;
            this.cbXeKhach.Location = new System.Drawing.Point(456, 35);
            this.cbXeKhach.Name = "cbXeKhach";
            this.cbXeKhach.Size = new System.Drawing.Size(73, 17);
            this.cbXeKhach.TabIndex = 10;
            this.cbXeKhach.Text = "Xe Khách";
            this.cbXeKhach.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(77, 109);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(111, 79);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTTTour);
            this.Controls.Add(this.GBoxTTLH);
            this.Name = "DangKyTour";
            this.Text = "DangKyTour";
            this.Load += new System.EventHandler(this.DangKyTour_Load);
            this.GBoxTTLH.ResumeLayout(false);
            this.GBoxTTLH.PerformLayout();
            this.gbTTTour.ResumeLayout(false);
            this.gbTTTour.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbTTTour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoLuongNguoi;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMayBay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbXeKhach;
        private System.Windows.Forms.CheckBox cbTauHoa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonRegister;
    }
}