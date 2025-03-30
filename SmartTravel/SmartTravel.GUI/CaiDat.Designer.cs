namespace SmartTravel.GUI
{
    partial class CaiDat
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.themeButton = new System.Windows.Forms.Button();
            this.languageButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(50, 50);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Đăng Xuất";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // themeButton
            // 
            this.themeButton.Location = new System.Drawing.Point(50, 100);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(119, 23);
            this.themeButton.TabIndex = 1;
            this.themeButton.Text = "Chỉnh Giao Diện";
            this.themeButton.UseVisualStyleBackColor = true;
            // 
            // languageButton
            // 
            this.languageButton.Location = new System.Drawing.Point(50, 150);
            this.languageButton.Name = "languageButton";
            this.languageButton.Size = new System.Drawing.Size(131, 23);
            this.languageButton.TabIndex = 2;
            this.languageButton.Text = "Điều Chỉnh Ngôn Ngữ";
            this.languageButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(50, 200);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Trở Về";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // CaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.themeButton);
            this.Controls.Add(this.languageButton);
            this.Controls.Add(this.returnButton);
            this.Name = "CaiDat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button themeButton;
        private System.Windows.Forms.Button languageButton;
        private System.Windows.Forms.Button returnButton;
    }
}