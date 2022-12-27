namespace MaturaHelper.UserInterface.Login
{
    partial class LoginPanel
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
            this.TB_UserLogin = new System.Windows.Forms.TextBox();
            this.TB_UserPassword = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Regestry = new System.Windows.Forms.Button();
            this.P_LoginPanel = new System.Windows.Forms.Panel();
            this.L_Password = new System.Windows.Forms.Label();
            this.L_Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P_LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_UserLogin
            // 
            this.TB_UserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UserLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_UserLogin.Location = new System.Drawing.Point(0, 81);
            this.TB_UserLogin.Name = "TB_UserLogin";
            this.TB_UserLogin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TB_UserLogin.Size = new System.Drawing.Size(250, 23);
            this.TB_UserLogin.TabIndex = 0;
            this.TB_UserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_UserPassword
            // 
            this.TB_UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UserPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_UserPassword.Location = new System.Drawing.Point(0, 124);
            this.TB_UserPassword.Name = "TB_UserPassword";
            this.TB_UserPassword.Size = new System.Drawing.Size(250, 23);
            this.TB_UserPassword.TabIndex = 1;
            this.TB_UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_UserPassword.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(0, 147);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(250, 55);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Zaloguj się";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Regestry
            // 
            this.btn_Regestry.FlatAppearance.BorderSize = 0;
            this.btn_Regestry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Regestry.Location = new System.Drawing.Point(0, 0);
            this.btn_Regestry.Name = "btn_Regestry";
            this.btn_Regestry.Size = new System.Drawing.Size(120, 48);
            this.btn_Regestry.TabIndex = 3;
            this.btn_Regestry.Text = "Zarejestruj się";
            this.btn_Regestry.UseVisualStyleBackColor = true;
            this.btn_Regestry.Click += new System.EventHandler(this.btn_Regestry_Click);
            // 
            // P_LoginPanel
            // 
            this.P_LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_LoginPanel.Controls.Add(this.btn_Login);
            this.P_LoginPanel.Controls.Add(this.TB_UserPassword);
            this.P_LoginPanel.Controls.Add(this.L_Password);
            this.P_LoginPanel.Controls.Add(this.TB_UserLogin);
            this.P_LoginPanel.Controls.Add(this.L_Login);
            this.P_LoginPanel.Controls.Add(this.label2);
            this.P_LoginPanel.Controls.Add(this.label1);
            this.P_LoginPanel.Location = new System.Drawing.Point(275, 150);
            this.P_LoginPanel.Name = "P_LoginPanel";
            this.P_LoginPanel.Size = new System.Drawing.Size(250, 202);
            this.P_LoginPanel.TabIndex = 4;
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.L_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Password.Location = new System.Drawing.Point(0, 104);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(53, 20);
            this.L_Password.TabIndex = 1;
            this.L_Password.Text = "Hasło";
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.L_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Login.Location = new System.Drawing.Point(0, 61);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(50, 20);
            this.L_Login.TabIndex = 0;
            this.L_Login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "PortalEDU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zaloguj się do";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.P_LoginPanel);
            this.Controls.Add(this.btn_Regestry);
            this.Name = "LoginPanel";
            this.Text = "LoginPanel";
            this.P_LoginPanel.ResumeLayout(false);
            this.P_LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_UserLogin;
        private System.Windows.Forms.TextBox TB_UserPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Regestry;
        private System.Windows.Forms.Panel P_LoginPanel;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}