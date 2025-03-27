namespace SmartTravel.GUI
{
    partial class DangKy
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
            this.Text = "DangKy";

            // Create Username Label
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUsername.Location = new System.Drawing.Point(100, 60);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 23);
            this.labelUsername.Text = "Tên đăng nhập";

            // Create Username TextBox
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUsername.Location = new System.Drawing.Point(200, 60);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 23);

            // Create Password Label
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPassword.Location = new System.Drawing.Point(100, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 23);
            this.labelPassword.Text = "Mật khẩu";

            // Create Password TextBox
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword.Location = new System.Drawing.Point(200, 110);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 23);
            this.textBoxPassword.PasswordChar = '*';

            // Create Confirm Password Label
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword.Location = new System.Drawing.Point(100, 160);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(100, 23);
            this.labelConfirmPassword.Text = "Nhập lại mật khẩu";

            // Create Confirm Password TextBox
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(200, 160);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(200, 23);
            this.textBoxConfirmPassword.PasswordChar = '*';

            // Create Email Label
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEmail.Location = new System.Drawing.Point(100, 210);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 23);
            this.labelEmail.Text = "Email";

            // Create Email TextBox
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmail.Location = new System.Drawing.Point(200, 210);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 23);

            // Create Register Button
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRegister.Location = new System.Drawing.Point(200, 260);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 23);
            this.buttonRegister.Text = "Đăng ký";


            // Create Login Button
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogin.Location = new System.Drawing.Point(320, 260);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.Text = "Đăng nhập";
   

            // Add controls to the form
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
    }
}