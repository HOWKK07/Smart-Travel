namespace SmartTravel.GUI
{
    partial class TaoLichTrinh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbDiemDen;
        private System.Windows.Forms.DateTimePicker dtpNgayGioKhoiHanh;
        private System.Windows.Forms.ComboBox cbKhachSan;
        private System.Windows.Forms.TextBox tbDiaChiKhachSan;
        private System.Windows.Forms.Button btnLayDiaChiHienTai;
        private System.Windows.Forms.Button btnGoiY;
        private System.Windows.Forms.ListBox lbLichTrinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbDiemDen = new System.Windows.Forms.ComboBox();
            this.dtpNgayGioKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.cbKhachSan = new System.Windows.Forms.ComboBox();
            this.tbDiaChiKhachSan = new System.Windows.Forms.TextBox();
            this.btnLayDiaChiHienTai = new System.Windows.Forms.Button();
            this.btnGoiY = new System.Windows.Forms.Button();
            this.lbLichTrinh = new System.Windows.Forms.ListBox();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Tạo Lịch Trình";

            // Điểm Đến ComboBox
            this.cbDiemDen.FormattingEnabled = true;
            this.cbDiemDen.Location = new System.Drawing.Point(50, 50);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(200, 21);
            this.cbDiemDen.TabIndex = 0;

            // Ngày Giờ Khởi Hành DateTimePicker
            this.dtpNgayGioKhoiHanh.Location = new System.Drawing.Point(50, 100);
            this.dtpNgayGioKhoiHanh.Name = "dtpNgayGioKhoiHanh";
            this.dtpNgayGioKhoiHanh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayGioKhoiHanh.TabIndex = 1;

            // Khách Sạn ComboBox
            this.cbKhachSan.FormattingEnabled = true;
            this.cbKhachSan.Location = new System.Drawing.Point(50, 150);
            this.cbKhachSan.Name = "cbKhachSan";
            this.cbKhachSan.Size = new System.Drawing.Size(200, 21);
            this.cbKhachSan.TabIndex = 2;

            // Địa Chỉ Khách Sạn TextBox
            this.tbDiaChiKhachSan.Location = new System.Drawing.Point(50, 200);
            this.tbDiaChiKhachSan.Name = "tbDiaChiKhachSan";
            this.tbDiaChiKhachSan.Size = new System.Drawing.Size(200, 20);
            this.tbDiaChiKhachSan.TabIndex = 3;

            // Lấy Địa Chỉ Hiện Tại Button
            this.btnLayDiaChiHienTai.Location = new System.Drawing.Point(260, 200);
            this.btnLayDiaChiHienTai.Name = "btnLayDiaChiHienTai";
            this.btnLayDiaChiHienTai.Size = new System.Drawing.Size(120, 23);
            this.btnLayDiaChiHienTai.TabIndex = 4;
            this.btnLayDiaChiHienTai.Text = "Lấy Địa Chỉ Hiện Tại";
            this.btnLayDiaChiHienTai.UseVisualStyleBackColor = true;

            // Gợi Ý Button
            this.btnGoiY.Location = new System.Drawing.Point(50, 250);
            this.btnGoiY.Name = "btnGoiY";
            this.btnGoiY.Size = new System.Drawing.Size(200, 23);
            this.btnGoiY.TabIndex = 5;
            this.btnGoiY.Text = "Gợi Ý Lịch Trình";
            this.btnGoiY.UseVisualStyleBackColor = true;


            // Lịch Trình ListBox
            this.lbLichTrinh.FormattingEnabled = true;
            this.lbLichTrinh.Location = new System.Drawing.Point(50, 300);
            this.lbLichTrinh.Name = "lbLichTrinh";
            this.lbLichTrinh.Size = new System.Drawing.Size(700, 130);
            this.lbLichTrinh.TabIndex = 6;

            // Add controls to the form
            this.Controls.Add(this.cbDiemDen);
            this.Controls.Add(this.dtpNgayGioKhoiHanh);
            this.Controls.Add(this.cbKhachSan);
            this.Controls.Add(this.tbDiaChiKhachSan);
            this.Controls.Add(this.btnLayDiaChiHienTai);
            this.Controls.Add(this.btnGoiY);
            this.Controls.Add(this.lbLichTrinh);
        }

        #endregion
    }
}