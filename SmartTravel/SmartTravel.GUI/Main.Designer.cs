﻿using System;

namespace SmartTravel.GUI
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.TextBox txtTimKiemDiemDen;
        private System.Windows.Forms.Button btnTaoLichTrinh;
        private System.Windows.Forms.Button btnCaiDatTrang;
        private System.Windows.Forms.ComboBox cboNgonNgu;
        private System.Windows.Forms.Button btnThemHinhAnhDiaDiemHot;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblTenTaiKhoan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.txtTimKiemDiemDen = new System.Windows.Forms.TextBox();
            this.btnTaoLichTrinh = new System.Windows.Forms.Button();
            this.btnCaiDatTrang = new System.Windows.Forms.Button();
            this.cboNgonNgu = new System.Windows.Forms.ComboBox();
            this.btnThemHinhAnhDiaDiemHot = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(50, 50);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(100, 30);
            this.btnDatPhong.TabIndex = 0;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(200, 50);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(100, 30);
            this.btnDatVe.TabIndex = 1;
            this.btnDatVe.Text = "Đặt Vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemDiemDen
            // 
            this.txtTimKiemDiemDen.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemDiemDen.Location = new System.Drawing.Point(50, 100);
            this.txtTimKiemDiemDen.Name = "txtTimKiemDiemDen";
            this.txtTimKiemDiemDen.Size = new System.Drawing.Size(250, 20);
            this.txtTimKiemDiemDen.TabIndex = 2;
            this.txtTimKiemDiemDen.Text = "Tìm kiếm điểm đến";
            this.txtTimKiemDiemDen.Enter += new System.EventHandler(this.txtTimKiemDiemDen_Enter);
            this.txtTimKiemDiemDen.Leave += new System.EventHandler(this.txtTimKiemDiemDen_Leave);
            // 
            // btnTaoLichTrinh
            // 
            this.btnTaoLichTrinh.Location = new System.Drawing.Point(50, 150);
            this.btnTaoLichTrinh.Name = "btnTaoLichTrinh";
            this.btnTaoLichTrinh.Size = new System.Drawing.Size(100, 30);
            this.btnTaoLichTrinh.TabIndex = 3;
            this.btnTaoLichTrinh.Text = "Tạo Lịch Trình";
            this.btnTaoLichTrinh.UseVisualStyleBackColor = true;
            // 
            // btnCaiDatTrang
            // 
            this.btnCaiDatTrang.Location = new System.Drawing.Point(200, 150);
            this.btnCaiDatTrang.Name = "btnCaiDatTrang";
            this.btnCaiDatTrang.Size = new System.Drawing.Size(100, 30);
            this.btnCaiDatTrang.TabIndex = 4;
            this.btnCaiDatTrang.Text = "Cài Đặt Trang";
            this.btnCaiDatTrang.UseVisualStyleBackColor = true;
            // 
            // cboNgonNgu
            // 
            this.cboNgonNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Việt"});
            this.cboNgonNgu.Location = new System.Drawing.Point(50, 200);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Size = new System.Drawing.Size(250, 21);
            this.cboNgonNgu.TabIndex = 5;
            // 
            // btnThemHinhAnhDiaDiemHot
            // 
            this.btnThemHinhAnhDiaDiemHot.Location = new System.Drawing.Point(50, 250);
            this.btnThemHinhAnhDiaDiemHot.Name = "btnThemHinhAnhDiaDiemHot";
            this.btnThemHinhAnhDiaDiemHot.Size = new System.Drawing.Size(200, 30);
            this.btnThemHinhAnhDiaDiemHot.TabIndex = 6;
            this.btnThemHinhAnhDiaDiemHot.Text = "Thêm Hình Ảnh Địa Điểm Hot";
            this.btnThemHinhAnhDiaDiemHot.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(50, 300);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(100, 30);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(600, 10);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(200, 20);
            this.lblTenTaiKhoan.TabIndex = 8;
            this.lblTenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(491, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(501, 221);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(603, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(537, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(146, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "label7";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.txtTimKiemDiemDen);
            this.Controls.Add(this.btnTaoLichTrinh);
            this.Controls.Add(this.btnCaiDatTrang);
            this.Controls.Add(this.cboNgonNgu);
            this.Controls.Add(this.btnThemHinhAnhDiaDiemHot);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Name = "Main";
            this.Text = "it ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtTimKiemDiemDen_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemDiemDen.Text == "Tìm kiếm điểm đến")
            {
                txtTimKiemDiemDen.Text = "";
                txtTimKiemDiemDen.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTimKiemDiemDen_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemDiemDen.Text == "")
            {
                txtTimKiemDiemDen.Text = "Tìm kiếm điểm đến";
                txtTimKiemDiemDen.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Code xử lý đăng nhập
            // Giả sử tên tài khoản là "User1" sau khi đăng nhập thành công
            string tenTaiKhoan = "User1";
            lblTenTaiKhoan.Text = "Xin chào, " + tenTaiKhoan;
        }

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}