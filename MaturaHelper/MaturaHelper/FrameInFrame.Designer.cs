namespace MaturaHelper
{
    partial class FrameInFrame
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
            this.P_Frame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // P_Frame
            // 
            this.P_Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Frame.Location = new System.Drawing.Point(0, 0);
            this.P_Frame.Name = "P_Frame";
            this.P_Frame.Size = new System.Drawing.Size(782, 503);
            this.P_Frame.TabIndex = 0;
            // 
            // FrameInFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.P_Frame);
            this.Name = "FrameInFrame";
            this.Text = "MATURAhelper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Frame;
    }
}