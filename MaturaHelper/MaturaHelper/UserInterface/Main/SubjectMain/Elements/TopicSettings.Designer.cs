namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    partial class TopicSettings
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
            this.L_SeeAble = new System.Windows.Forms.Label();
            this.chb_UserCanSee = new System.Windows.Forms.CheckBox();
            this.L_TopictToSection = new System.Windows.Forms.Label();
            this.FLP_AllTopicsToSection = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Ready = new System.Windows.Forms.Button();
            this.btn_AddTopic = new System.Windows.Forms.Button();
            this.L_SectionPath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_SectionName
            // 
            this.TB_SectionName.Location = new System.Drawing.Point(16, 32);
            this.TB_SectionName.Name = "TB_SectionName";
            this.TB_SectionName.Size = new System.Drawing.Size(100, 22);
            this.TB_SectionName.TabIndex = 0;
            // 
            // L_SectionName
            // 
            this.L_SectionName.AutoSize = true;
            this.L_SectionName.Location = new System.Drawing.Point(13, 13);
            this.L_SectionName.Name = "L_SectionName";
            this.L_SectionName.Size = new System.Drawing.Size(92, 16);
            this.L_SectionName.TabIndex = 1;
            this.L_SectionName.Text = "Nazwa sekcji :";
            // 
            // L_SeeAble
            // 
            this.L_SeeAble.AutoSize = true;
            this.L_SeeAble.Location = new System.Drawing.Point(13, 61);
            this.L_SeeAble.Name = "L_SeeAble";
            this.L_SeeAble.Size = new System.Drawing.Size(112, 16);
            this.L_SeeAble.TabIndex = 2;
            this.L_SeeAble.Text = "Widoczność sekji";
            // 
            // chb_UserCanSee
            // 
            this.chb_UserCanSee.AutoSize = true;
            this.chb_UserCanSee.Location = new System.Drawing.Point(13, 81);
            this.chb_UserCanSee.Name = "chb_UserCanSee";
            this.chb_UserCanSee.Size = new System.Drawing.Size(242, 20);
            this.chb_UserCanSee.TabIndex = 3;
            this.chb_UserCanSee.Text = "Widoczna dla każdego użytkownika";
            this.chb_UserCanSee.UseVisualStyleBackColor = true;
            // 
            // L_TopictToSection
            // 
            this.L_TopictToSection.AutoSize = true;
            this.L_TopictToSection.Location = new System.Drawing.Point(13, 104);
            this.L_TopictToSection.Name = "L_TopictToSection";
            this.L_TopictToSection.Size = new System.Drawing.Size(173, 16);
            this.L_TopictToSection.TabIndex = 4;
            this.L_TopictToSection.Text = "Tematy powiązane z sekcją";
            // 
            // FLP_AllTopicsToSection
            // 
            this.FLP_AllTopicsToSection.AutoScroll = true;
            this.FLP_AllTopicsToSection.Location = new System.Drawing.Point(13, 124);
            this.FLP_AllTopicsToSection.Name = "FLP_AllTopicsToSection";
            this.FLP_AllTopicsToSection.Size = new System.Drawing.Size(391, 249);
            this.FLP_AllTopicsToSection.TabIndex = 5;
            // 
            // btn_Ready
            // 
            this.btn_Ready.Location = new System.Drawing.Point(16, 380);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(75, 23);
            this.btn_Ready.TabIndex = 6;
            this.btn_Ready.Text = "Gotowe";
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // btn_AddTopic
            // 
            this.btn_AddTopic.Location = new System.Drawing.Point(291, 95);
            this.btn_AddTopic.Name = "btn_AddTopic";
            this.btn_AddTopic.Size = new System.Drawing.Size(113, 23);
            this.btn_AddTopic.TabIndex = 7;
            this.btn_AddTopic.Text = "Dodaj temat";
            this.btn_AddTopic.UseVisualStyleBackColor = true;
            this.btn_AddTopic.Click += new System.EventHandler(this.btn_AddTopic_Click);
            // 
            // L_SectionPath
            // 
            this.L_SectionPath.AutoSize = true;
            this.L_SectionPath.Location = new System.Drawing.Point(291, 32);
            this.L_SectionPath.Name = "L_SectionPath";
            this.L_SectionPath.Size = new System.Drawing.Size(44, 16);
            this.L_SectionPath.TabIndex = 8;
            this.L_SectionPath.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TopicSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.L_SectionPath);
            this.Controls.Add(this.btn_AddTopic);
            this.Controls.Add(this.btn_Ready);
            this.Controls.Add(this.FLP_AllTopicsToSection);
            this.Controls.Add(this.L_TopictToSection);
            this.Controls.Add(this.chb_UserCanSee);
            this.Controls.Add(this.L_SeeAble);
            this.Controls.Add(this.L_SectionName);
            this.Controls.Add(this.TB_SectionName);
            this.Name = "TopicSettings";
            this.Text = "TopicSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_SectionName;
        private System.Windows.Forms.Label L_SeeAble;
        private System.Windows.Forms.Label L_TopictToSection;
        private System.Windows.Forms.FlowLayoutPanel FLP_AllTopicsToSection;
        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Button btn_AddTopic;
        public System.Windows.Forms.TextBox TB_SectionName;
        public System.Windows.Forms.CheckBox chb_UserCanSee;
        private System.Windows.Forms.Label L_SectionPath;
        private System.Windows.Forms.TextBox textBox1;
    }
}