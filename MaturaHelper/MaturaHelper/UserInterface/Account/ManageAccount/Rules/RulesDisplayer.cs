using MaturaHelper.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MaturaHelper.UserInterface.Account.ManageAccount.Rules
{
    public enum WhichRule
    {
        ProvisionServices,
        PlatformRules
    }

    public partial class RulesDisplayer : Form
    {

        private FrameInFrame frameInFrame;
        private Form BackTo;
        MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
             "; userid = " + SQLConnetion.UserID +
             "; password = " + SQLConnetion.PassWord +
             " ; database = " + SQLConnetion.DataBase + " ;");
        public RulesDisplayer(WhichRule rule, FrameInFrame frame, Form Back)
        {
            InitializeComponent();
            frameInFrame = frame;
            BackTo = Back;
            connection.Open();

            int IDrule = -1;
            switch(rule)
            {
                case WhichRule.ProvisionServices:
                    IDrule = 1;
                    break;

                case WhichRule.PlatformRules:
                    IDrule = 2;
                    break;
            }
            //String querry = "SELECT * FROM userdata WHERE userpassword = '" + Password + "' AND userlogin = '" + Login + "';";
            String querry = "SELECT * FROM rules WHERE RuleID = '" + IDrule.ToString() + "';";

            MySqlDataAdapter adapter = new MySqlDataAdapter(querry, connection);

            DataTable dTable = new DataTable();
            adapter.Fill(dTable);


            if (dTable.Rows.Count > 0)
            {
                DataRow row = dTable.Rows[0];

                String HeadCos = dTable.Rows[0]["Head"].ToString();
                String TextCos = dTable.Rows[0]["RuleText"].ToString();

                
                L_Head.Text = HeadCos;
                L_Text.Text = TextCos;

            }
            else
            {
                //bWasSucessfull = false;
            }
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(BackTo);
        }
    }
}
