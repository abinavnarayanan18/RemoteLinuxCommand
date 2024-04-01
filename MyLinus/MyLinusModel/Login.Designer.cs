namespace MyLinus.MyLinusModel
{
    partial class Login
    {
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox TxtHostName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnBrowsePEM;

        private void InitializeComponent()
        {
            this.labelHostName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.TxtHostName = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnBrowsePEM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.labelHostName.Location = new System.Drawing.Point(150, 80);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(130, 27);
            this.labelHostName.TabIndex = 0;
            this.labelHostName.Text = "Host Name : ";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.labelUserName.Location = new System.Drawing.Point(150, 120);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(116, 27);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Username : ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.labelPassword.Location = new System.Drawing.Point(150, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(111, 27);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password : ";
            // 
            // TxtHostName
            // 
            this.TxtHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtHostName.Location = new System.Drawing.Point(300, 80);
            this.TxtHostName.Name = "TxtHostName";
            this.TxtHostName.Size = new System.Drawing.Size(200, 30);
            this.TxtHostName.TabIndex = 3;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtUserName.Location = new System.Drawing.Point(300, 120);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(200, 30);
            this.TxtUserName.TabIndex = 4;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtPassword.Location = new System.Drawing.Point(300, 160);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(200, 30);
            this.TxtPassword.TabIndex = 5;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.Location = new System.Drawing.Point(300, 260);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 40);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnBrowsePEM
            // 
            this.BtnBrowsePEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnBrowsePEM.Location = new System.Drawing.Point(300, 200);
            this.BtnBrowsePEM.Name = "BtnBrowsePEM";
            this.BtnBrowsePEM.Size = new System.Drawing.Size(150, 40);
            this.BtnBrowsePEM.TabIndex = 7;
            this.BtnBrowsePEM.Text = "Browse PEM File";
            this.BtnBrowsePEM.UseVisualStyleBackColor = true;
            this.BtnBrowsePEM.Click += new System.EventHandler(this.BtnBrowsePEM_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBrowsePEM);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtHostName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelHostName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
