using MaturaHelper.SQLconnetionNames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySqlConnector;
using MaturaHelper.Enums;
using System.Threading;

namespace MaturaHelper.BUser
{
    public class User
    {
        public UserRighs UserRighs { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String UserEmail { get; set; }
        public bool bWasSucessfull = false;

        public User(String Login, String Passw)
        {
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
               "; userid = " + SQLConnetion.UserID +
               "; password = " + SQLConnetion.PassWord +
               " ; database = " + SQLConnetion.DataBase + " ;");

            try
            {
                connection.Open();
                //String querry = "SELECT * FROM userdata WHERE userpassword = '" + Password + "' AND userlogin = '" + Login + "';";
                String querry = "SELECT * FROM userdata WHERE userpassword = '" + Passw + "' AND userlogin = '" + Login + "';";

                MySqlDataAdapter adapter = new MySqlDataAdapter(querry, connection);

                DataTable dTable = new DataTable();
                adapter.Fill(dTable);


                if (dTable.Rows.Count > 0)
                {
                    DataRow row = dTable.Rows[0];

                    Password = dTable.Rows[0]["UserPassword"].ToString();
                    UserName = dTable.Rows[0]["UserLogin"].ToString();
                    UserEmail = dTable.Rows[0]["EMail"].ToString();
                    int UserRightsID = (int)dTable.Rows[0]["AccounTypeID"];
                    switch (UserRightsID)
                    {
                        case 0:
                            UserRighs = UserRighs.NormalUser;
                            break;

                        case 1:
                            UserRighs = UserRighs.Editor;
                            break;

                        case 2:
                            UserRighs = UserRighs.Admin;
                            break;
                    }
                    bWasSucessfull = true;
                }
                else
                {
                    bWasSucessfull = false;
                }
            }
            catch
            {
                //Nie udało się połączyć z serwerami PortalEDU, sprawdź później
                MessageBox.Show("Nie udało nam się połączyć ze serwerami PortalEDU, spróbuj później");
            }
            finally
            {
                connection.Close();
            }  
        }
    }
}
