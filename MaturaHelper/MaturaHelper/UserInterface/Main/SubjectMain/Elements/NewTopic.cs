using MaturaHelper.SQLconnetionNames;
using MySql.Data.MySqlClient;
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
    public partial class NewTopic : Form
    {
        int SectionID;
        string CurrentPath;
        int belongingID;
        public NewTopic(int BelongingID)
        {
            InitializeComponent();
            belongingID = BelongingID;  
        }

        private void btn_AddTopic_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

            connection.Open();
            MySqlCommand cmd = new MySqlCommand("insert into " + SQLConnetion.Scopes + " values (@ID, @NUCS, @NazwaZakresu, @SSID, @BID)", connection);
            //MySqlCommand cmd = new MySqlCommand("insert into " + SQLConnetion.Scopes + " values (@ID, @TZID, @Name, @IDWG)", connection);

            cmd.Parameters.AddWithValue("@ID", 0);
            cmd.Parameters.AddWithValue("@NUCS", SectionID);
            cmd.Parameters.AddWithValue("@NazwaZakresu", TB_TopicName.Text);
            cmd.Parameters.AddWithValue("@SSID", 0);
            cmd.Parameters.AddWithValue("@BID", belongingID);

            cmd.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void TB_TopicName_TextChanged(object sender, EventArgs e)
        {
            L_TopicPath.Text = "Po dodaniu tematu :" + CurrentPath + TB_TopicName.Text + "\\";
        }
    }
}
