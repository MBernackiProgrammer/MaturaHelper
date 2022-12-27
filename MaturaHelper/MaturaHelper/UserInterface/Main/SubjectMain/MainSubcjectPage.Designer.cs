namespace MaturaHelper.UserInterface.Main
{
    partial class MainSubcjectPage
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
            this.fp_AllTopics = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Return = new System.Windows.Forms.Button();
            this.P_DisplayPanel = new System.Windows.Forms.Panel();
            this.fp_AllTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // fp_AllTopics
            // 
            this.fp_AllTopics.AutoScroll = true;
            this.fp_AllTopics.Controls.Add(this.btn_Return);
            this.fp_AllTopics.Dock = System.Windows.Forms.DockStyle.Left;
            this.fp_AllTopics.Location = new System.Drawing.Point(0, 0);
            this.fp_AllTopics.Name = "fp_AllTopics";
            this.fp_AllTopics.Size = new System.Drawing.Size(200, 450);
            this.fp_AllTopics.TabIndex = 0;
            // 
            // btn_Return
            // 
            this.btn_Return.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Return.Location = new System.Drawing.Point(3, 3);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(200, 50);
            this.btn_Return.TabIndex = 0;
            this.btn_Return.Text = "Strona główna";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // P_DisplayPanel
            // 
            this.P_DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DisplayPanel.Location = new System.Drawing.Point(200, 0);
            this.P_DisplayPanel.Name = "P_DisplayPanel";
            this.P_DisplayPanel.Size = new System.Drawing.Size(600, 450);
            this.P_DisplayPanel.TabIndex = 1;
            // 
            // MainSubcjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P_DisplayPanel);
            this.Controls.Add(this.fp_AllTopics);
            this.Name = "MainSubcjectPage";
            this.Text = "MainSubcjectPage";
            this.fp_AllTopics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fp_AllTopics;
        private System.Windows.Forms.Panel P_DisplayPanel;
        private System.Windows.Forms.Button btn_Return;
    }
}