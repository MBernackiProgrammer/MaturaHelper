using MaturaHelper.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    public partial class SubTopic : Form
    {
        int belonging;
        int cellID;
        FrameInFrame FrameInFrame;
        
        public SubTopic(string name, int Belonging, int CellID, FrameInFrame frame)
        {
            InitializeComponent();
            btn_Name.Text = name;
            belonging = Belonging;
            cellID = CellID;
            FrameInFrame = frame;
        }

        private void dodajTematToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTopic newTopic = new NewTopic(belonging);
            newTopic.ShowDialog();

        }

        private void btn_Name_Click(object sender, EventArgs e)
        {
            FrameInFrame frm = new FrameInFrame();
            frm.ChangeForm(new MaturaHelper.UserInterface.Main.SubjectMain.Elements.TopicSettings(frm, belonging, cellID));
            frm.ShowDialog();  
        }

        private void dodajZadanieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otwórzMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameInFrame frm = new FrameInFrame();
            frm.ChangeForm(new MaturaHelper.UserInterface.Main.SubjectMain.Elements.TopicSettings(frm, belonging, cellID));
            frm.ShowDialog();
        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Messa
            Helper.DelateSection(belonging);
        }
    }
}
