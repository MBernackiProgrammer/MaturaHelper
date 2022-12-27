namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    partial class AddSection
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
            this.TB_SectionName = new System.Windows.Forms.TextBox();
            this.L_SectionName = new System.Windows.Forms.Label();
            this.btn_AddSection = new System.Windows.Forms.Button();
            this.ch_SeeAbleForUsers = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TB_SectionName
            // 
            this.TB_SectionName.Location = new System.Drawing.Point(32, 35);
            this.TB_SectionName.Name = "TB_SectionName";
            this.TB_SectionName.Size = new System.Drawing.Size(100, 22);
            this.TB_SectionName.TabIndex = 0;
            // 
            // L_SectionName
            // 
            this.L_SectionName.AutoSize = true;
            this.L_SectionName.Location = new System.Drawing.Point(32, 13);
            this.L_SectionName.Name = "L_SectionName";
            this.L_SectionName.Size = new System.Drawing.Size(86, 16);
            this.L_SectionName.TabIndex = 1;
            this.L_SectionName.Text = "Nazwa sekcji";
            // 
            // btn_AddSection
            // 
            this.btn_AddSection.Location = new System.Drawing.Point(32, 89);
            this.btn_AddSection.Name = "btn_AddSection";
            this.btn_AddSection.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSection.TabIndex = 2;
            this.btn_AddSection.Text = "Dodaj sekcję";
            this.btn_AddSection.UseVisualStyleBackColor = true;
            this.btn_AddSection.Click += new System.EventHandler(this.btn_AddSection_Click);
            // 
            // ch_SeeAbleForUsers
            // 
            this.ch_SeeAbleForUsers.AutoSize = true;
            this.ch_SeeAbleForUsers.Location = new System.Drawing.Point(32, 63);
            this.ch_SeeAbleForUsers.Name = "ch_SeeAbleForUsers";
            this.ch_SeeAbleForUsers.Size = new System.Drawing.Size(195, 20);
            this.ch_SeeAbleForUsers.TabIndex = 3;
            this.ch_SeeAbleForUsers.Text = "Widoczne dla użytkowników";
            this.ch_SeeAbleForUsers.UseVisualStyleBackColor = true;
            // 
            // AddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ch_SeeAbleForUsers);
            this.Controls.Add(this.btn_AddSection);
            this.Controls.Add(this.L_SectionName);
            this.Controls.Add(this.TB_SectionName);
            this.Name = "AddSection";
            this.Text = "AddSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_SectionName;
        private System.Windows.Forms.Label L_SectionName;
        private System.Windows.Forms.Button btn_AddSection;
        private System.Windows.Forms.CheckBox ch_SeeAbleForUsers;
    }
}