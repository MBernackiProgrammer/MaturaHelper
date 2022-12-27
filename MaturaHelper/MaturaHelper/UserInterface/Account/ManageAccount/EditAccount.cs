//Copyright Mateusz Bernacki. All Rights Reserved.
//Copyright© 2022 Mateusz Bernacki

//API PortalEDU
using MaturaHelper.UserInterface.Account.ManageAccount.Rules;

//API SYSYTEM
using System;
using System.Windows.Forms;


namespace MaturaHelper.UserInterface.Account.ManageAccount
{
    public partial class EditAccount : Form
    {
        private FrameInFrame frameInFrame;
        private Form backForm;
        public EditAccount(FrameInFrame frame, Form BackForm)
        {
            frameInFrame = frame;
            backForm = BackForm;
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(backForm);
        }

        private void btn_PlatformRules_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Account.ManageAccount.Rules.RulesDisplayer(WhichRule.PlatformRules, frameInFrame, this));
        }

        private void btn_ServicesRules_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Account.ManageAccount.Rules.RulesDisplayer(WhichRule.ProvisionServices, frameInFrame, this));
        }
    }
}
