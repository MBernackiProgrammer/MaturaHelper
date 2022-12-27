using MaturaHelper.SQLconnetionNames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MaturaHelper.Enums;

namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    public partial class AddSection : Form
    {
        WhereIAm whereIAm;
        public AddSection(WhereIAm where)
        {
            InitializeComponent();
            whereIAm = where;
        }

        private void btn_AddSection_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

            connection.Open();

            int IDWhereIAm = Helper.FromRightToInt(whereIAm);
            MySqlCommand cmd = new MySqlCommand("insert into " + SQLConnetion.Scopes + " values (@ID, @NUCS, @NazwaZakresu, @SSID, @BID)", connection);

            cmd.Parameters.AddWithValue("@ID", 0);

            int Out = -1;
            if(ch_SeeAbleForUsers.Checked == true)
            {
                Out = 1;
            }
            else
            {
                Out = 0;
            }

            cmd.Parameters.AddWithValue("@NUCS", Out.ToString());
            cmd.Parameters.AddWithValue("@NazwaZakresu", TB_SectionName.Text);
            cmd.Parameters.AddWithValue("@SSID", IDWhereIAm);
            cmd.Parameters.AddWithValue("@BID", 0);


            cmd.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
