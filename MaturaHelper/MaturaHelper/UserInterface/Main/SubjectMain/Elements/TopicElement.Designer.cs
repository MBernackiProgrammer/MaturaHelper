namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    partial class TopicElement
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
            this.btn_Topic = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podsekcjęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńSekcjęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Topic
            // 
            this.btn_Topic.Location = new System.Drawing.Point(-2, 1);
            this.btn_Topic.Name = "btn_Topic";
            this.btn_Topic.Size = new System.Drawing.Size(174, 78);
            this.btn_Topic.TabIndex = 1;
            this.btn_Topic.Text = "button1";
            this.btn_Topic.UseVisualStyleBackColor = true;
            this.btn_Topic.Click += new System.EventHandler(this.btn_Topic_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.otwórzMenuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 76);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zadanieToolStripMenuItem,
            this.podsekcjęToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // zadanieToolStripMenuItem
            // 
            this.zadanieToolStripMenuItem.Name = "zadanieToolStripMenuItem";
            this.zadanieToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.zadanieToolStripMenuItem.Text = "Zadanie";
            this.zadanieToolStripMenuItem.Click += new System.EventHandler(this.zadanieToolStripMenuItem_Click);
            // 
            // podsekcjęToolStripMenuItem
            // 
            this.podsekcjęToolStripMenuItem.Name = "podsekcjęToolStripMenuItem";
            this.podsekcjęToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.podsekcjęToolStripMenuItem.Text = "Podsekcję";
            this.podsekcjęToolStripMenuItem.Click += new System.EventHandler(this.podsekcjeToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńSekcjęToolStripMenuItem});
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.usuńToolStripMenuItem.Text = "Usuń";
            // 
            // usuńSekcjęToolStripMenuItem
            // 
            this.usuńSekcjęToolStripMenuItem.Name = "usuńSekcjęToolStripMenuItem";
            this.usuńSekcjęToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.usuńSekcjęToolStripMenuItem.Text = "Usuń sekcję";
            this.usuńSekcjęToolStripMenuItem.Click += new System.EventHandler(this.usunSekcjeToolStripMenuItem_Click);
            // 
            // otwórzMenuToolStripMenuItem
            // 
            this.otwórzMenuToolStripMenuItem.Name = "otwórzMenuToolStripMenuItem";
            this.otwórzMenuToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.otwórzMenuToolStripMenuItem.Text = "Otwórz menu";
            this.otwórzMenuToolStripMenuItem.Click += new System.EventHandler(this.otwórzMenuToolStripMenuItem_Click);
            // 
            // TopicElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 74);
            this.Controls.Add(this.btn_Topic);
            this.Name = "TopicElement";
            this.Text = "TopicElement";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Topic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podsekcjęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńSekcjęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzMenuToolStripMenuItem;
    }
}