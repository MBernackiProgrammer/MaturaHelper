namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    partial class NewTopic
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
            this.L_TopicName = new System.Windows.Forms.Label();
            this.TB_TopicName = new System.Windows.Forms.TextBox();
            this.btn_AddTopic = new System.Windows.Forms.Button();
            this.L_YouAddTo = new System.Windows.Forms.Label();
            this.L_TopicPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_TopicName
            // 
            this.L_TopicName.AutoSize = true;
            this.L_TopicName.Location = new System.Drawing.Point(13, 13);
            this.L_TopicName.Name = "L_TopicName";
            this.L_TopicName.Size = new System.Drawing.Size(99, 16);
            this.L_TopicName.TabIndex = 0;
            this.L_TopicName.Text = "Nazwa teamatu";
            // 
            // TB_TopicName
            // 
            this.TB_TopicName.Location = new System.Drawing.Point(13, 33);
            this.TB_TopicName.Name = "TB_TopicName";
            this.TB_TopicName.Size = new System.Drawing.Size(100, 22);
            this.TB_TopicName.TabIndex = 1;
            this.TB_TopicName.TextChanged += new System.EventHandler(this.TB_TopicName_TextChanged);
            // 
            // btn_AddTopic
            // 
            this.btn_AddTopic.Location = new System.Drawing.Point(13, 62);
            this.btn_AddTopic.Name = "btn_AddTopic";
            this.btn_AddTopic.Size = new System.Drawing.Size(100, 23);
            this.btn_AddTopic.TabIndex = 2;
            this.btn_AddTopic.Text = "Dodaj temat";
            this.btn_AddTopic.UseVisualStyleBackColor = true;
            this.btn_AddTopic.Click += new System.EventHandler(this.btn_AddTopic_Click);
            // 
            // L_YouAddTo
            // 
            this.L_YouAddTo.AutoSize = true;
            this.L_YouAddTo.Location = new System.Drawing.Point(181, 12);
            this.L_YouAddTo.Name = "L_YouAddTo";
            this.L_YouAddTo.Size = new System.Drawing.Size(134, 16);
            this.L_YouAddTo.TabIndex = 3;
            this.L_YouAddTo.Text = "Dodajesz do ścieżki :";
            // 
            // L_TopicPath
            // 
            this.L_TopicPath.AutoSize = true;
            this.L_TopicPath.Location = new System.Drawing.Point(184, 38);
            this.L_TopicPath.Name = "L_TopicPath";
            this.L_TopicPath.Size = new System.Drawing.Size(125, 16);
            this.L_TopicPath.TabIndex = 4;
            this.L_TopicPath.Text = "Po dodaniu tematu :";
            // 
            // NewTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_TopicPath);
            this.Controls.Add(this.L_YouAddTo);
            this.Controls.Add(this.btn_AddTopic);
            this.Controls.Add(this.TB_TopicName);
            this.Controls.Add(this.L_TopicName);
            this.Name = "NewTopic";
            this.Text = "NewTopic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_TopicName;
        private System.Windows.Forms.TextBox TB_TopicName;
        private System.Windows.Forms.Button btn_AddTopic;
        private System.Windows.Forms.Label L_YouAddTo;
        private System.Windows.Forms.Label L_TopicPath;
    }
}