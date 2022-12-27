using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using MaturaHelper.Enums;
using MaturaHelper.SQLconnetionNames;
using System.Windows.Forms;

namespace MaturaHelper
{
    internal class Helper
    {
        public static int FromRightToInt(WhereIAm userRighs)
        {
            int IDreturn;
            switch (userRighs)
            {
                case WhereIAm.Polish:
                    IDreturn = 1;
                    break;

                case WhereIAm.Math:
                    IDreturn = 2;
                    break;

                case WhereIAm.English:
                    IDreturn = 3;
                    break;

                default:
                    IDreturn = -1;
                    break;
            }

            return IDreturn;
        }


        private static void StartDelating(int ID)
        {
            int IDtoShare = ID;

            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");
            connection.Open();

            String q = "DELETE FROM " + SQLConnetion.Scopes + " WHERE ID='" + IDtoShare.ToString() + "';";
            MySqlCommand cmd = new MySqlCommand(q, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            DeletaAllIn(IDtoShare);

        }
        private static void DeletaAllIn(int DelateID)
        {
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");
            connection.Open();
            String querryV2 = "SELECT * FROM " + SQLConnetion.Scopes + " WHERE BID=" + DelateID.ToString() + ";";

            MySqlDataAdapter adapterV2 = new MySqlDataAdapter(querryV2, connection);

            DataTable dTableV2 = new DataTable();
            adapterV2.Fill(dTableV2);

            String q = "DELETE FROM " + SQLConnetion.Scopes + " WHERE BID='" + DelateID.ToString() + "';";
            MySqlCommand cmd = new MySqlCommand(q, connection);
            cmd.ExecuteNonQuery();


            foreach (DataRow dr in dTableV2.Rows)
            {
                DeletaAllIn((int)dr["ID"]);
            }
            connection.Close();
        }
        public static void DelateSection(int SectionID)
        {
            StartDelating(SectionID);
        }
    }
}
