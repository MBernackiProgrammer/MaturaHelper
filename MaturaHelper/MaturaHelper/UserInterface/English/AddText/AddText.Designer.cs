namespace MaturaHelper.UserInterface.English.AddText
{
    partial class AddText
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
            this.L_AddTextTo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_AddText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_AddTextTo
            // 
            this.L_AddTextTo.AutoSize = true;
            this.L_AddTextTo.Location = new System.Drawing.Point(13, 13);
            this.L_AddTextTo.Name = "L_AddTextTo";
            this.L_AddTextTo.Size = new System.Drawing.Size(121, 16);
            this.L_AddTextTo.TabIndex = 0;
            this.L_AddTextTo.Text = "Dodajesz tekst do :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(772, 315);
            this.textBox1.TabIndex = 1;
            // 
            // btn_AddText
            // 
            this.btn_AddText.Location = new System.Drawing.Point(669, 22);
            this.btn_AddText.Name = "btn_AddText";
            this.btn_AddText.Size = new System.Drawing.Size(119, 23);
            this.btn_AddText.TabIndex = 2;
            this.btn_AddText.Text = "Dodaj tekst";
            this.btn_AddText.UseVisualStyleBackColor = true;
            this.btn_AddText.Click += new System.EventHandler(this.btn_AddText_Click);
            // 
            // AddText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.L_AddTextTo);
            this.Name = "AddText";
            this.Text = "AddText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_AddTextTo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_AddText;
    }
}