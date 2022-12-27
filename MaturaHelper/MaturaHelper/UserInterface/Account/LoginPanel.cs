//Copyright Mateusz Bernacki. All Rights Reserved.
//Copyright© 2022 Mateusz Bernacki

//API PortalEDU
using MaturaHelper.SQLconnetionNames;
using MySqlConnector;
using MaturaHelper.BUser;

//API SYSYTEM
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaturaHelper.UserInterface.Login
{
    public partial class LoginPanel : Form
    {
        private FrameInFrame frameInFrame;
        public LoginPanel(FrameInFrame frame)
        {
            InitializeComponent();
            frameInFrame = frame;
        }

        MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
               "; userid = " + SQLConnetion.UserID +
               "; password = " + SQLConnetion.PassWord +
               " ; database = " + SQLConnetion.DataBase + " ;");

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user = new User(TB_UserLogin.Text, TB_UserPassword.Text);

            if(user != null)
            {
                if(user.bWasSucessfull)
                {
                    frameInFrame.user = user;
                    frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.SelectSubject(frameInFrame));
                }
                else
                {
                    MessageBox.Show("Hasło bądź login zostało źle podane, spróbój ponownie");
                }
            }  
        }

        private void btn_Regestry_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.LoginAndRegistry.Regestry(frameInFrame, this));
        }
    }
}
