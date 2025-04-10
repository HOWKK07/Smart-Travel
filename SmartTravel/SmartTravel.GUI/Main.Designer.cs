using System;

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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}