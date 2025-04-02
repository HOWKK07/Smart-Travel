using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartTravel.GUI
{
    partial class DatPhong : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnQuayLai;

        private System.Windows.Forms.Panel pnlThongTinDatPhong;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnDatPhong;

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
            this.components = new System.ComponentModel.Container();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.pnlThongTinDatPhong = new System.Windows.Forms.Panel();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.pnlThongTinDatPhong.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(12, 12);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(760, 350);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);

            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(12, 380);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(200, 20);
            this.txtDiaDiem.TabIndex = 1;

            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(230, 380);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 2;

            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(350, 380);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);

            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(450, 380);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;

            // 
            // pnlThongTinDatPhong
            // 
            this.pnlThongTinDatPhong.Controls.Add(this.txtTenKhach);
            this.pnlThongTinDatPhong.Controls.Add(this.txtSoDienThoai);
            this.pnlThongTinDatPhong.Controls.Add(this.btnDatPhong);
            this.pnlThongTinDatPhong.Location = new System.Drawing.Point(12, 420);
            this.pnlThongTinDatPhong.Name = "pnlThongTinDatPhong";
            this.pnlThongTinDatPhong.Size = new System.Drawing.Size(760, 120);
            this.pnlThongTinDatPhong.TabIndex = 5;
            this.pnlThongTinDatPhong.Visible = false;

            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(3, 3);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(200, 20);
            this.txtTenKhach.TabIndex = 0;
            this.txtTenKhach.Text = "Tên khách hàng";

            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(3, 29);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtSoDienThoai.TabIndex = 1;
            this.txtSoDienThoai.Text = "Số điện thoại khách hàng";

            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(3, 55);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(75, 23);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;

            // 
            // DatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlThongTinDatPhong);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnQuayLai);
            this.Text = "Đặt Phòng";

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.pnlThongTinDatPhong.ResumeLayout(false);
            this.pnlThongTinDatPhong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string diaDiem = txtDiaDiem.Text;
            string giaText = txtGia.Text;
            decimal gia = 0;

            if (!string.IsNullOrEmpty(giaText))
            {
                decimal.TryParse(giaText, out gia);
            }

            // Giả sử bạn có một danh sách các khách sạn, bạn có thể lọc danh sách này dựa trên địa điểm và giá
            List<KhachSan> khachSans = LayDanhSachKhachSan(); // Lấy danh sách khách sạn từ nguồn dữ liệu của bạn
            var khachSansLoc = khachSans.Where(h => h.DiaDiem.Contains(diaDiem) && (gia == 0 || h.Gia <= gia)).ToList();

            dgvPhong.DataSource = khachSansLoc;
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count > 0)
            {
                pnlThongTinDatPhong.Visible = true;
            }
        }

        private List<KhachSan> LayDanhSachKhachSan()
        {
            // Lấy danh sách khách sạn từ nguồn dữ liệu của bạn
            // Đây chỉ là ví dụ, bạn cần thay thế bằng dữ liệu thực tế
            return new List<KhachSan>
            {
                new KhachSan { Ten = "Khách sạn A", DiaDiem = "Hà Nội", Gia = 100 },
                new KhachSan { Ten = "Khách sạn B", DiaDiem = "Hà Nội", Gia = 200 },
                new KhachSan { Ten = "Khách sạn C", DiaDiem = "Đà Nẵng", Gia = 150 },
                // Thêm các khách sạn khác
            };
        }
    }

    public class KhachSan
    {
        public string Ten { get; set; }
        public string DiaDiem { get; set; }
        public decimal Gia { get; set; }
    }
}