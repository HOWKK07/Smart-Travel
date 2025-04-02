namespace SmartTravel.GUI
{
    partial class FormNguoiDung
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDangKyTour;
        private System.Windows.Forms.TextBox txtTimKiemDiemDen;
        private System.Windows.Forms.Button btnTaoLichTrinh;
        private System.Windows.Forms.ComboBox cboNgonNgu;
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
            this.btnDangKyTour = new System.Windows.Forms.Button();
            this.txtTimKiemDiemDen = new System.Windows.Forms.TextBox();
            this.btnTaoLichTrinh = new System.Windows.Forms.Button();
            this.cboNgonNgu = new System.Windows.Forms.ComboBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
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
            // btnDangKyTour
            // 
            this.btnDangKyTour.Location = new System.Drawing.Point(200, 150);
            this.btnDangKyTour.Name = "btnDangKyTour";
            this.btnDangKyTour.Size = new System.Drawing.Size(150, 30);
            this.btnDangKyTour.TabIndex = 5;
            this.btnDangKyTour.Text = "Đăng Ký Tour";
            this.btnDangKyTour.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemDiemDen
            // 
            this.txtTimKiemDiemDen.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemDiemDen.Location = new System.Drawing.Point(50, 200);
            this.txtTimKiemDiemDen.Name = "txtTimKiemDiemDen";
            this.txtTimKiemDiemDen.Size = new System.Drawing.Size(250, 20);
            this.txtTimKiemDiemDen.TabIndex = 6;
            this.txtTimKiemDiemDen.Text = "Tìm kiếm điểm đến";

            // 
            // btnTaoLichTrinh
            // 
            this.btnTaoLichTrinh.Location = new System.Drawing.Point(50, 250);
            this.btnTaoLichTrinh.Name = "btnTaoLichTrinh";
            this.btnTaoLichTrinh.Size = new System.Drawing.Size(100, 30);
            this.btnTaoLichTrinh.TabIndex = 7;
            this.btnTaoLichTrinh.Text = "Tạo Lịch Trình";
            this.btnTaoLichTrinh.UseVisualStyleBackColor = true;
            // 
            // cboNgonNgu
            // 
            this.cboNgonNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Việt"});
            this.cboNgonNgu.Location = new System.Drawing.Point(50, 300);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Size = new System.Drawing.Size(250, 21);
            this.cboNgonNgu.TabIndex = 9;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(50, 400);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(100, 30);
            this.btnDangNhap.TabIndex = 11;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(600, 10);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(200, 20);
            this.lblTenTaiKhoan.TabIndex = 12;
            this.lblTenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnDangKyTour);
            this.Controls.Add(this.txtTimKiemDiemDen);
            this.Controls.Add(this.btnTaoLichTrinh);
            this.Controls.Add(this.cboNgonNgu);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Name = "FormNguoiDung";
            this.Text = "FormNguoiDung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}