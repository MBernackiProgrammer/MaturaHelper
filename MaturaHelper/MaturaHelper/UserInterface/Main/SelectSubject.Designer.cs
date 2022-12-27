namespace MaturaHelper.UserInterface.Main
{
    partial class SelectSubject
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
            this.btn_Polish = new System.Windows.Forms.Button();
            this.btn_Math = new System.Windows.Forms.Button();
            this.btn_english = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.l_LogedAs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Polish
            // 
            this.btn_Polish.Location = new System.Drawing.Point(87, 140);
            this.btn_Polish.Name = "btn_Polish";
            this.btn_Polish.Size = new System.Drawing.Size(127, 125);
            this.btn_Polish.TabIndex = 0;
            this.btn_Polish.Text = "Zadania z języka polskiego";
            this.btn_Polish.UseVisualStyleBackColor = true;
            this.btn_Polish.Click += new System.EventHandler(this.btn_Polish_Click);
            // 
            // btn_Math
            // 
            this.btn_Math.Location = new System.Drawing.Point(317, 140);
            this.btn_Math.Name = "btn_Math";
            this.btn_Math.Size = new System.Drawing.Size(127, 125);
            this.btn_Math.TabIndex = 1;
            this.btn_Math.Text = "Zadania z matematyki";
            this.btn_Math.UseVisualStyleBackColor = true;
            this.btn_Math.Click += new System.EventHandler(this.btn_Math_Click);
            // 
            // btn_english
            // 
            this.btn_english.Location = new System.Drawing.Point(523, 140);
            this.btn_english.Name = "btn_english";
            this.btn_english.Size = new System.Drawing.Size(127, 125);
            this.btn_english.TabIndex = 2;
            this.btn_english.Text = "Zadania z języka angielskiego";
            this.btn_english.UseVisualStyleBackColor = true;
            this.btn_english.Click += new System.EventHandler(this.btn_english_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(685, 404);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(103, 34);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "Ustawienia";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(13, 414);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(153, 23);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Wyłącz aplikację";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // l_LogedAs
            // 
            this.l_LogedAs.AutoSize = true;
            this.l_LogedAs.Location = new System.Drawing.Point(13, 13);
            this.l_LogedAs.Name = "l_LogedAs";
            this.l_LogedAs.Size = new System.Drawing.Size(44, 16);
            this.l_LogedAs.TabIndex = 5;
            this.l_LogedAs.Text = "label1";
            // 
            // SelectSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_LogedAs);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_english);
            this.Controls.Add(this.btn_Math);
            this.Controls.Add(this.btn_Polish);
            this.Name = "SelectSubject";
            this.Text = "SelectSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Polish;
        private System.Windows.Forms.Button btn_Math;
        private System.Windows.Forms.Button btn_english;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label l_LogedAs;
    }
}