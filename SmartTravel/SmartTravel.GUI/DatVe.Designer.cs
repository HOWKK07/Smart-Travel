using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTravel.GUI
{
    public partial class DatVe : Form
    {
        private System.ComponentModel.IContainer components = null;
        private RadioButton rbMotChieu;
        private RadioButton rbKhuHoi;
        private Label lblNgayDi;
        private DateTimePicker dtpNgayDi;
        private Label lblNgayVe;
        private DateTimePicker dtpNgayVe;
        private Label lblSoNguoiLon;
        private NumericUpDown nudSoNguoiLon;
        private Label lblSoTreEm;
        private NumericUpDown nudSoTreEm;
        private ComboBox cbHangHangKhong;
        private DataGridView dgvThongTinChuyenBay;
        private Button btnNhapThongTinHanhKhach;
        private DataGridView dgvThongTinHanhKhach;
        private Panel pnlThongTinHanhKhach;
        private Button btnDatVe;

        public DatVe()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rbMotChieu = new System.Windows.Forms.RadioButton();
            this.rbKhuHoi = new System.Windows.Forms.RadioButton();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoiLon = new System.Windows.Forms.Label();
            this.nudSoNguoiLon = new System.Windows.Forms.NumericUpDown();
            this.lblSoTreEm = new System.Windows.Forms.Label();
            this.nudSoTreEm = new System.Windows.Forms.NumericUpDown();
            this.lblHangHangKhong = new System.Windows.Forms.Label();
            this.cbHangHangKhong = new System.Windows.Forms.ComboBox();
            this.dgvThongTinChuyenBay = new System.Windows.Forms.DataGridView();
            this.btnNhapThongTinHanhKhach = new System.Windows.Forms.Button();
            this.pnlThongTinHanhKhach = new System.Windows.Forms.Panel();
            this.dgvThongTinHanhKhach = new System.Windows.Forms.DataGridView();
            this.btnDatVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoiLon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTreEm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChuyenBay)).BeginInit();
            this.pnlThongTinHanhKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHanhKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMotChieu
            // 
            this.rbMotChieu.Checked = true;
            this.rbMotChieu.Location = new System.Drawing.Point(10, 10);
            this.rbMotChieu.Name = "rbMotChieu";
            this.rbMotChieu.Size = new System.Drawing.Size(104, 24);
            this.rbMotChieu.TabIndex = 0;
            this.rbMotChieu.TabStop = true;
            this.rbMotChieu.Text = "Một Chiều";
            this.rbMotChieu.CheckedChanged += new System.EventHandler(this.RbMotChieu_CheckedChanged);
            // 
            // rbKhuHoi
            // 
            this.rbKhuHoi.Location = new System.Drawing.Point(150, 10);
            this.rbKhuHoi.Name = "rbKhuHoi";
            this.rbKhuHoi.Size = new System.Drawing.Size(104, 24);
            this.rbKhuHoi.TabIndex = 1;
            this.rbKhuHoi.Text = "Khứ Hồi";
            this.rbKhuHoi.CheckedChanged += new System.EventHandler(this.RbKhuHoi_CheckedChanged);
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.Location = new System.Drawing.Point(10, 50);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(100, 23);
            this.lblNgayDi.TabIndex = 2;
            this.lblNgayDi.Text = "Ngày Đi";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Location = new System.Drawing.Point(150, 50);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDi.TabIndex = 3;
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.Location = new System.Drawing.Point(10, 90);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(100, 23);
            this.lblNgayVe.TabIndex = 4;
            this.lblNgayVe.Text = "Ngày Về";
            this.lblNgayVe.Visible = false;
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.Location = new System.Drawing.Point(150, 90);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayVe.TabIndex = 5;
            this.dtpNgayVe.Visible = false;
            // 
            // lblSoNguoiLon
            // 
            this.lblSoNguoiLon.Location = new System.Drawing.Point(10, 130);
            this.lblSoNguoiLon.Name = "lblSoNguoiLon";
            this.lblSoNguoiLon.Size = new System.Drawing.Size(100, 23);
            this.lblSoNguoiLon.TabIndex = 6;
            this.lblSoNguoiLon.Text = "Số Người Lớn";
            // 
            // nudSoNguoiLon
            // 
            this.nudSoNguoiLon.Location = new System.Drawing.Point(150, 130);
            this.nudSoNguoiLon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSoNguoiLon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoNguoiLon.Name = "nudSoNguoiLon";
            this.nudSoNguoiLon.Size = new System.Drawing.Size(120, 20);
            this.nudSoNguoiLon.TabIndex = 7;
            this.nudSoNguoiLon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoTreEm
            // 
            this.lblSoTreEm.Location = new System.Drawing.Point(10, 170);
            this.lblSoTreEm.Name = "lblSoTreEm";
            this.lblSoTreEm.Size = new System.Drawing.Size(100, 23);
            this.lblSoTreEm.TabIndex = 8;
            this.lblSoTreEm.Text = "Số Trẻ Em";
            // 
            // nudSoTreEm
            // 
            this.nudSoTreEm.Location = new System.Drawing.Point(150, 170);
            this.nudSoTreEm.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSoTreEm.Name = "nudSoTreEm";
            this.nudSoTreEm.Size = new System.Drawing.Size(120, 20);
            this.nudSoTreEm.TabIndex = 9;
            // 
            // lblHangHangKhong
            // 
            this.lblHangHangKhong.Location = new System.Drawing.Point(10, 210);
            this.lblHangHangKhong.Name = "lblHangHangKhong";
            this.lblHangHangKhong.Size = new System.Drawing.Size(100, 23);
            this.lblHangHangKhong.TabIndex = 10;
            this.lblHangHangKhong.Text = "Hãng Hàng Không";
            // 
            // cbHangHangKhong
            // 
            this.cbHangHangKhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHangHangKhong.Items.AddRange(new object[] {
            "Hãng A",
            "Hãng B",
            "Hãng C"});
            this.cbHangHangKhong.Location = new System.Drawing.Point(150, 210);
            this.cbHangHangKhong.Name = "cbHangHangKhong";
            this.cbHangHangKhong.Size = new System.Drawing.Size(121, 21);
            this.cbHangHangKhong.TabIndex = 11;
            this.cbHangHangKhong.SelectedIndexChanged += new System.EventHandler(this.CbHangHangKhong_SelectedIndexChanged);
            // 
            // dgvThongTinChuyenBay
            // 
            this.dgvThongTinChuyenBay.Location = new System.Drawing.Point(10, 250);
            this.dgvThongTinChuyenBay.MultiSelect = false;
            this.dgvThongTinChuyenBay.Name = "dgvThongTinChuyenBay";
            this.dgvThongTinChuyenBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinChuyenBay.Size = new System.Drawing.Size(760, 200);
            this.dgvThongTinChuyenBay.TabIndex = 12;
            // 
            // btnNhapThongTinHanhKhach
            // 
            this.btnNhapThongTinHanhKhach.Location = new System.Drawing.Point(10, 460);
            this.btnNhapThongTinHanhKhach.Name = "btnNhapThongTinHanhKhach";
            this.btnNhapThongTinHanhKhach.Size = new System.Drawing.Size(75, 23);
            this.btnNhapThongTinHanhKhach.TabIndex = 13;
            this.btnNhapThongTinHanhKhach.Text = "Nhập Thông Tin Hành Khách";
            this.btnNhapThongTinHanhKhach.Click += new System.EventHandler(this.BtnNhapThongTinHanhKhach_Click);
            // 
            // pnlThongTinHanhKhach
            // 
            this.pnlThongTinHanhKhach.Controls.Add(this.dgvThongTinHanhKhach);
            this.pnlThongTinHanhKhach.Location = new System.Drawing.Point(10, 500);
            this.pnlThongTinHanhKhach.Name = "pnlThongTinHanhKhach";
            this.pnlThongTinHanhKhach.Size = new System.Drawing.Size(760, 300);
            this.pnlThongTinHanhKhach.TabIndex = 14;
            this.pnlThongTinHanhKhach.Visible = false;
            // 
            // dgvThongTinHanhKhach
            // 
            this.dgvThongTinHanhKhach.Location = new System.Drawing.Point(0, 0);
            this.dgvThongTinHanhKhach.Name = "dgvThongTinHanhKhach";
            this.dgvThongTinHanhKhach.Size = new System.Drawing.Size(760, 300);
            this.dgvThongTinHanhKhach.TabIndex = 0;
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(10, 810);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(75, 23);
            this.btnDatVe.TabIndex = 15;
            this.btnDatVe.Text = "Đặt Vé";
            this.btnDatVe.Click += new System.EventHandler(this.BtnDatVe_Click);
            // 
            // DatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.rbMotChieu);
            this.Controls.Add(this.rbKhuHoi);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.lblNgayVe);
            this.Controls.Add(this.dtpNgayVe);
            this.Controls.Add(this.lblSoNguoiLon);
            this.Controls.Add(this.nudSoNguoiLon);
            this.Controls.Add(this.lblSoTreEm);
            this.Controls.Add(this.nudSoTreEm);
            this.Controls.Add(this.lblHangHangKhong);
            this.Controls.Add(this.cbHangHangKhong);
            this.Controls.Add(this.dgvThongTinChuyenBay);
            this.Controls.Add(this.btnNhapThongTinHanhKhach);
            this.Controls.Add(this.pnlThongTinHanhKhach);
            this.Controls.Add(this.btnDatVe);
            this.Name = "DatVe";
            this.Text = "Đặt Vé Máy Bay";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoiLon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTreEm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChuyenBay)).EndInit();
            this.pnlThongTinHanhKhach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHanhKhach)).EndInit();
            this.ResumeLayout(false);

        }

        private void RbMotChieu_CheckedChanged(object sender, EventArgs e)
        {
            lblNgayVe.Visible = false;
            dtpNgayVe.Visible = false;
        }

        private void RbKhuHoi_CheckedChanged(object sender, EventArgs e)
        {
            lblNgayVe.Visible = true;
            dtpNgayVe.Visible = true;
        }

        private void CbHangHangKhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa các tùy chọn chuyến bay trước đó
            dgvThongTinChuyenBay.Rows.Clear();
            dgvThongTinChuyenBay.Columns.Clear();

            // Tạo DataTable để chứa thông tin chuyến bay
            DataTable dt = new DataTable();
            dt.Columns.Add("Số Hiệu Chuyến Bay");
            dt.Columns.Add("Sân Bay");
            dt.Columns.Add("Giờ Khởi Hành");
            dt.Columns.Add("Giờ Đến");
            dt.Columns.Add("Hãng Khai Thác");

            // Tải các tùy chọn chuyến bay dựa trên hãng hàng không được chọn
            switch (cbHangHangKhong.SelectedItem.ToString())
            {
                case "Hãng A":
                    dt.Rows.Add("A101", "Sân Bay A1", "10:00 AM", "12:00 PM", "Hãng A");
                    dt.Rows.Add("A102", "Sân Bay A2", "01:00 PM", "03:00 PM", "Hãng A");
                    dt.Rows.Add("A103", "Sân Bay A3", "04:00 PM", "06:00 PM", "Hãng A");
                    break;
                case "Hãng B":
                    dt.Rows.Add("B101", "Sân Bay B1", "09:00 AM", "11:00 AM", "Hãng B");
                    dt.Rows.Add("B102", "Sân Bay B2", "12:00 PM", "02:00 PM", "Hãng B");
                    dt.Rows.Add("B103", "Sân Bay B3", "03:00 PM", "05:00 PM", "Hãng B");
                    break;
                case "Hãng C":
                    dt.Rows.Add("C101", "Sân Bay C1", "08:00 AM", "10:00 AM", "Hãng C");
                    dt.Rows.Add("C102", "Sân Bay C2", "11:00 AM", "01:00 PM", "Hãng C");
                    dt.Rows.Add("C103", "Sân Bay C3", "02:00 PM", "04:00 PM", "Hãng C");
                    break;
            }

            // Gán DataTable cho DataGridView
            dgvThongTinChuyenBay.DataSource = dt;
        }

        private void BtnNhapThongTinHanhKhach_Click(object sender, EventArgs e)
        {
            if (dgvThongTinChuyenBay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chuyến bay để nhập thông tin hành khách.", "Thông báo");
                return;
            }

            // Tạo DataTable để chứa thông tin hành khách
            DataTable dtHanhKhach = new DataTable();
            dtHanhKhach.Columns.Add("Loại Vé");
            dtHanhKhach.Columns.Add("Họ");
            dtHanhKhach.Columns.Add("Tên Đệm và Tên");
            dtHanhKhach.Columns.Add("Giới Tính");
            dtHanhKhach.Columns.Add("Ngày Tháng Năm Sinh");
            dtHanhKhach.Columns.Add("Quốc Tịch");
            dtHanhKhach.Columns.Add("CCCD hoặc Passport");

            // Thêm các hàng cho thông tin người lớn
            for (int i = 0; i < nudSoNguoiLon.Value; i++)
            {
                DataRow row = dtHanhKhach.NewRow();
                row["Loại Vé"] = "Người Lớn";
                dtHanhKhach.Rows.Add(row);
            }

            // Thêm các hàng cho thông tin trẻ em
            for (int i = 0; i < nudSoTreEm.Value; i++)
            {
                DataRow row = dtHanhKhach.NewRow();
                row["Loại Vé"] = "Trẻ Em";
                row["Quốc Tịch"] = ""; // Không cần nhập quốc tịch cho trẻ em
                row["CCCD hoặc Passport"] = ""; // Không cần nhập CCCD hoặc Passport cho trẻ em
                dtHanhKhach.Rows.Add(row);
            }

            // Gán DataTable cho DataGridView
            dgvThongTinHanhKhach.DataSource = dtHanhKhach;
            pnlThongTinHanhKhach.Visible = true;
        }

        private void BtnDatVe_Click(object sender, EventArgs e)
        {
            if (dgvThongTinChuyenBay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chuyến bay để đặt vé.", "Thông báo");
                return;
            }

            if (dgvThongTinHanhKhach.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin hành khách.", "Thông báo");
                return;
            }

            // Lấy thông tin chuyến bay được chọn
            var selectedRow = dgvThongTinChuyenBay.SelectedRows[0];
            var soHieuChuyenBay = selectedRow.Cells["Số Hiệu Chuyến Bay"].Value.ToString();
            var sanBay = selectedRow.Cells["Sân Bay"].Value.ToString();
            var gioKhoiHanh = selectedRow.Cells["Giờ Khởi Hành"].Value.ToString();
            var gioDen = selectedRow.Cells["Giờ Đến"].Value.ToString();
            var hangKhaiThac = selectedRow.Cells["Hãng Khai Thác"].Value.ToString();

            // Hiển thị thông tin đặt vé
            string thongTinDatVe = $"Thông Tin Đặt Vé:\n" +
                                    $"Số Hiệu Chuyến Bay: {soHieuChuyenBay}\n" +
                                    $"Số Người Lớn: {nudSoNguoiLon.Value}\n" +
                                    $"Số Trẻ Em: {nudSoTreEm.Value}\n" +
                                    $"Hãng Hàng Không: {cbHangHangKhong.SelectedItem}\n" +
                                    $"Sân Bay: {sanBay}\n" +
                                    $"Giờ Khởi Hành: {gioKhoiHanh}\n" +
                                    $"Giờ Đến: {gioDen}\n" +
                                    $"Hãng Khai Thác: {hangKhaiThac}\n" +
                                    $"Ngày Đi: {dtpNgayDi.Value.ToShortDateString()}\n";

            if (rbKhuHoi.Checked)
            {
                thongTinDatVe += $"Ngày Về: {dtpNgayVe.Value.ToShortDateString()}\n";
            }

            // Hiển thị thông tin hành khách
            thongTinDatVe += "Thông Tin Hành Khách:\n";
            foreach (DataGridViewRow row in dgvThongTinHanhKhach.Rows)
            {
                thongTinDatVe += $"{row.Cells["Loại Vé"].Value}: {row.Cells["Họ"].Value} {row.Cells["Tên Đệm và Tên"].Value}, " +
                                 $"{row.Cells["Giới Tính"].Value}, {row.Cells["Ngày Tháng Năm Sinh"].Value}, " +
                                 $"{row.Cells["Quốc Tịch"].Value}, {row.Cells["CCCD hoặc Passport"].Value}\n";
            }

            // Sử dụng MessageBox để hiển thị thông tin đặt vé (chỉ để minh họa)
            MessageBox.Show(thongTinDatVe, "Đặt Vé Máy Bay");

            // Mã để hiển thị kết quả chuyến bay nên được thêm vào đây
            // Ví dụ:
            string ketQuaChuyenBay = $"Kết Quả Chuyến Bay:\n" +
                                     $"Sân Bay: {sanBay}\n" +
                                     $"Giờ Khởi Hành: {gioKhoiHanh}\n" +
                                     $"Giờ Đến: {gioDen}\n" +
                                     $"Hãng Khai Thác: {hangKhaiThac}";

            MessageBox.Show(ketQuaChuyenBay, "Kết Quả Chuyến Bay");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Label lblHangHangKhong;
    }
}