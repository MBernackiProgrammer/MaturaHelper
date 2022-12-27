namespace MaturaHelper.UserInterface.Account.ManageAccount
{
    partial class EditAccount
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
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_ChangeUserName = new System.Windows.Forms.Button();
            this.btn_ChangeEMail = new System.Windows.Forms.Button();
            this.btn_PlatformRules = new System.Windows.Forms.Button();
            this.btn_ServicesRules = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(13, 13);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(206, 23);
            this.btn_ChangePassword.TabIndex = 0;
            this.btn_ChangePassword.Text = "Zmień hasło";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeUserName
            // 
            this.btn_ChangeUserName.Location = new System.Drawing.Point(13, 43);
            this.btn_ChangeUserName.Name = "btn_ChangeUserName";
            this.btn_ChangeUserName.Size = new System.Drawing.Size(206, 23);
            this.btn_ChangeUserName.TabIndex = 1;
            this.btn_ChangeUserName.Text = "Zmień nazwę użytkownika";
            this.btn_ChangeUserName.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeEMail
            // 
            this.btn_ChangeEMail.Location = new System.Drawing.Point(13, 73);
            this.btn_ChangeEMail.Name = "btn_ChangeEMail";
            this.btn_ChangeEMail.Size = new System.Drawing.Size(206, 23);
            this.btn_ChangeEMail.TabIndex = 2;
            this.btn_ChangeEMail.Text = "Zmień E-Mail";
            this.btn_ChangeEMail.UseVisualStyleBackColor = true;
            // 
            // btn_PlatformRules
            // 
            this.btn_PlatformRules.Location = new System.Drawing.Point(13, 103);
            this.btn_PlatformRules.Name = "btn_PlatformRules";
            this.btn_PlatformRules.Size = new System.Drawing.Size(206, 23);
            this.btn_PlatformRules.TabIndex = 3;
            this.btn_PlatformRules.Text = "Regulamin platformy";
            this.btn_PlatformRules.UseVisualStyleBackColor = true;
            this.btn_PlatformRules.Click += new System.EventHandler(this.btn_PlatformRules_Click);
            // 
            // btn_ServicesRules
            // 
            this.btn_ServicesRules.Location = new System.Drawing.Point(13, 133);
            this.btn_ServicesRules.Name = "btn_ServicesRules";
            this.btn_ServicesRules.Size = new System.Drawing.Size(206, 23);
            this.btn_ServicesRules.TabIndex = 4;
            this.btn_ServicesRules.Text = "Regulamin świadczenia usług";
            this.btn_ServicesRules.UseVisualStyleBackColor = true;
            this.btn_ServicesRules.Click += new System.EventHandler(this.btn_ServicesRules_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(713, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Powrót";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ServicesRules);
            this.Controls.Add(this.btn_PlatformRules);
            this.Controls.Add(this.btn_ChangeEMail);
            this.Controls.Add(this.btn_ChangeUserName);
            this.Controls.Add(this.btn_ChangePassword);
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_ChangeUserName;
        private System.Windows.Forms.Button btn_ChangeEMail;
        private System.Windows.Forms.Button btn_PlatformRules;
        private System.Windows.Forms.Button btn_ServicesRules;
        private System.Windows.Forms.Button btn_Back;
    }
}