namespace MaturaHelper.UserInterface.NormalUser
{
    partial class AllSubTopics
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
            this.L_SectionTopics = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_SectionTopics
            // 
            this.L_SectionTopics.AutoSize = true;
            this.L_SectionTopics.Location = new System.Drawing.Point(13, 13);
            this.L_SectionTopics.Name = "L_SectionTopics";
            this.L_SectionTopics.Size = new System.Drawing.Size(91, 16);
            this.L_SectionTopics.TabIndex = 0;
            this.L_SectionTopics.Text = "Tematy sekcji";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 399);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(195, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Powróć";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AllSubTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.L_SectionTopics);
            this.Name = "AllSubTopics";
            this.Text = "AllSubTopics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_SectionTopics;
        private System.Windows.Forms.Button btn_back;
    }
}