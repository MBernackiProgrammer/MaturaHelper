namespace MaturaHelper.UserInterface.Account.ManageAccount.Rules
{
    partial class RulesDisplayer
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
            this.L_Head = new System.Windows.Forms.Label();
            this.L_Text = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Head
            // 
            this.L_Head.AutoSize = true;
            this.L_Head.BackColor = System.Drawing.Color.Transparent;
            this.L_Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Head.Location = new System.Drawing.Point(13, 13);
            this.L_Head.Name = "L_Head";
            this.L_Head.Size = new System.Drawing.Size(118, 42);
            this.L_Head.TabIndex = 0;
            this.L_Head.Text = "label1";
            // 
            // L_Text
            // 
            this.L_Text.AutoSize = true;
            this.L_Text.BackColor = System.Drawing.Color.Transparent;
            this.L_Text.Location = new System.Drawing.Point(17, 55);
            this.L_Text.Name = "L_Text";
            this.L_Text.Size = new System.Drawing.Size(44, 16);
            this.L_Text.TabIndex = 1;
            this.L_Text.Text = "label1";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(713, 415);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Wyjdź";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // RulesDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.L_Text);
            this.Controls.Add(this.L_Head);
            this.Name = "RulesDisplayer";
            this.Text = "RulesDisplayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Head;
        private System.Windows.Forms.Label L_Text;
        private System.Windows.Forms.Button btn_Exit;
    }
}