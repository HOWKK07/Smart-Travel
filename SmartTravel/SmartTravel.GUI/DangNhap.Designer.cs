namespace SmartTravel.GUI
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "DangNhap";

            // Create Username Label
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUsername.Location = new System.Drawing.Point(100, 100);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 23);
            this.labelUsername.Text = "Tên đăng nhập";

            // Create Username TextBox
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUsername.Location = new System.Drawing.Point(200, 100);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 23);

            // Create Password Label
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPassword.Location = new System.Drawing.Point(100, 150);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 23);
            this.labelPassword.Text = "Mật khẩu";

            // Create Password TextBox
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword.Location = new System.Drawing.Point(200, 150);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 23);
            this.textBoxPassword.PasswordChar = '*';

            // Create Login Button
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogin.Location = new System.Drawing.Point(200, 200);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.Text = "Đăng nhập";


            // Create Register Button
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRegister.Location = new System.Drawing.Point(320, 200);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 23);
            this.buttonRegister.Text = "Đăng ký";


            // Add controls to the form
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegister);
        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
    }
}