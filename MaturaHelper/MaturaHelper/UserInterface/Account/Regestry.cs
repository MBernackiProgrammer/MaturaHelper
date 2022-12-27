//Copyright Mateusz Bernacki. All Rights Reserved.
//Copyright© 2022 Mateusz Bernacki

//API PortalEDU
using MaturaHelper.SQLconnetionNames;

//API SQL
using MySql.Data.MySqlClient;

//API SYSYTEM
using System;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MaturaHelper.UserInterface.LoginAndRegistry
{
    public partial class Regestry : Form
    {
        private FrameInFrame frameInFrame;
        private Form backForm;

        public Regestry(FrameInFrame frame, Form BackForm)
        {
            InitializeComponent();
            frameInFrame = frame;
            backForm = BackForm;
        }

        private void btn_Regestry_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

            connection.Open();
            MySqlCommand cmd = new MySqlCommand("insert into " + SQLConnetion.LoginTable + " values (@ID, @UserLogin, @UserPassword, @EMail, @AccounTypeID, @Imie, @Nazwisko)", connection);

            cmd.Parameters.AddWithValue("@ID", 0);
            cmd.Parameters.AddWithValue("@UserPassword", TB_Password.Text);
            cmd.Parameters.AddWithValue("@UserLogin", TB_UserName.Text);
            cmd.Parameters.AddWithValue("@EMail", TB_UserEMail.Text);
            cmd.Parameters.AddWithValue("@AccounTypeID", 0);
            cmd.Parameters.AddWithValue("@Imie", TB_Name.Text);
            cmd.Parameters.AddWithValue("@Nazwisko", TB_Surname.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Rejestracja powiodła się");
            frameInFrame.ChangeForm(backForm);

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(backForm); 
        }
    }
}
