using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//MaturaHelper using api 
using MaturaHelper.Enums;
using MaturaHelper.SQLconnetionNames;
using MaturaHelper.UserInterface.Main.SubjectMain.Elements;

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace MaturaHelper.UserInterface.Main
{
    public partial class MainSubcjectPage : Form
    {
        private FrameInFrame frameInFrame;
        private WhereIAm whereIAm;

        MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server + 
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

        public void ChangeForm(String NameAdd, int IDlaunch, int belonging, int mySqlID)
        {
            TopicConstruct Topic = new TopicConstruct(NameAdd, IDlaunch, frameInFrame, this, whereIAm);
            TopicElement topicElement = new TopicElement(Topic);
            topicElement.TopLevel = false;
            topicElement.FormBorderStyle = FormBorderStyle.None;
            topicElement.Dock = DockStyle.Top;
            fp_AllTopics.Controls.Add(topicElement);
            fp_AllTopics.Tag = topicElement;
            topicElement.Show();

        }

        public MainSubcjectPage(FrameInFrame frame, WhereIAm where)
        {
            InitializeComponent();

            frameInFrame = frame;
            whereIAm = where;

            try
            {
                int IDWhereIAm = Helper.FromRightToInt(whereIAm);
                connection.Open();
                String querry = "SELECT * FROM "+ SQLConnetion.Scopes + " WHERE SSID="+ IDWhereIAm.ToString() + ";";

                MySqlDataAdapter adapter = new MySqlDataAdapter(querry, connection);

                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                bool WasDiplayed = false;
                foreach (DataRow dr in dTable.Rows)
                {
                    if((int)dr["NUCS"] == 1 || frameInFrame.user.UserRighs == UserRighs.Admin || frameInFrame.user.UserRighs == UserRighs.Editor)
                    {
                        ChangeForm(dr["nazwazakresu"].ToString(), 0, (int)dr["ID"], 0);
                        WasDiplayed = true;
                    }
                }

                if(WasDiplayed == false)
                {
                    ChangeForm("Aktualnie brak zakresów", 0, -1, -1);
                }

                ///////////////////////////////////////////////////////////
                /// Base ports 
                /// 1 - Add section
                ///
                ///
                ///
                if(frameInFrame.user.UserRighs == UserRighs.Editor || frameInFrame.user.UserRighs == UserRighs.Admin)
                {
                    ChangeForm("Dodaj sekcję", 1, -1, -1);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddScope(WhereIAm whereIAm)
        {
            switch(whereIAm)
            {
                case WhereIAm.English:
                    //Pojawia się okienko z możliwością dodania sekcji w angielskim
                    break;

                case WhereIAm.Math:

                    break;

                case WhereIAm.Polish:

                    break;
            }
        }
        /// <summary>
        /// Funkcja służy do uzupełnienia panela bocznego tematami z zakresu J. Polskiego
        /// </summary>
        public void CompleteWithPolish()
        {

        }

        /// <summary>
        /// Funkcja służy do uzupełnienia panela bocznego tematami z zakresu Matematyki
        /// </summary>
        public void CompleteWithMath()
        {

        }

        /// <summary>
        /// Funkcja służy do uzupełnienia panela bocznego tematami z zakresu J. Angilskiego
        /// </summary>
        public void CompleteWithEnglish()
        {

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.SelectSubject(frameInFrame));
        }
    }
}
