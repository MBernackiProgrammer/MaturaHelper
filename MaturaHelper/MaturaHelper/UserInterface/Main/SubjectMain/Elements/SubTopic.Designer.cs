namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    partial class SubTopic
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
            this.components = new System.ComponentModel.Container();
            this.btn_Name = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajTematToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Name
            // 
            this.btn_Name.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_Name.Location = new System.Drawing.Point(-6, 0);
            this.btn_Name.Name = "btn_Name";
            this.btn_Name.Size = new System.Drawing.Size(385, 50);
            this.btn_Name.TabIndex = 1;
            this.btn_Name.Text = "button1";
            this.btn_Name.UseVisualStyleBackColor = true;
            this.btn_Name.Click += new System.EventHandler(this.btn_Name_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTematToolStripMenuItem,
            this.dodajZadanieToolStripMenuItem,
            this.otwórzMenuToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // dodajTematToolStripMenuItem
            // 
            this.dodajTematToolStripMenuItem.Name = "dodajTematToolStripMenuItem";
            this.dodajTematToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.dodajTematToolStripMenuItem.Text = "Dodaj temat";
            this.dodajTematToolStripMenuItem.Click += new System.EventHandler(this.dodajTematToolStripMenuItem_Click);
            // 
            // dodajZadanieToolStripMenuItem
            // 
            this.dodajZadanieToolStripMenuItem.Name = "dodajZadanieToolStripMenuItem";
            this.dodajZadanieToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.dodajZadanieToolStripMenuItem.Text = "Dodaj zadanie";
            this.dodajZadanieToolStripMenuItem.Click += new System.EventHandler(this.dodajZadanieToolStripMenuItem_Click);
            // 
            // otwórzMenuToolStripMenuItem
            // 
            this.otwórzMenuToolStripMenuItem.Name = "otwórzMenuToolStripMenuItem";
            this.otwórzMenuToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.otwórzMenuToolStripMenuItem.Text = "Otwórz menu";
            this.otwórzMenuToolStripMenuItem.Click += new System.EventHandler(this.otwórzMenuToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usunToolStripMenuItem_Click);
            // 
            // SubTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 41);
            this.Controls.Add(this.btn_Name);
            this.Name = "SubTopic";
            this.Text = "SubTopic";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajTematToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
    }
}