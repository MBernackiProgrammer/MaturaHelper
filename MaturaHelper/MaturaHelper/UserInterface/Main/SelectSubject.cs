using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaturaHelper.UserInterface.Main
{
    public partial class SelectSubject : Form
    {
        private FrameInFrame frameInFrame;
        public SelectSubject(FrameInFrame frame)
        {
            InitializeComponent();
            frameInFrame = frame;
            l_LogedAs.Text = "Witaj ponownie, " + frameInFrame.user.UserName;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Account.ManageAccount.EditAccount(frameInFrame,this));
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frameInFrame.Close();
        }

        private void btn_english_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.MainSubcjectPage(frameInFrame, Enums.WhereIAm.English));
        }

        private void btn_Math_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.MainSubcjectPage(frameInFrame, Enums.WhereIAm.Math));
        }

        private void btn_Polish_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.MainSubcjectPage(frameInFrame, Enums.WhereIAm.Polish));
        }
    }
}
