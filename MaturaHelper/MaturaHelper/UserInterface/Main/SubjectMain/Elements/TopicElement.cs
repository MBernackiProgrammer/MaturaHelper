using System;
using System.Windows.Forms;
using MaturaHelper.Enums;
using MaturaHelper.SQLconnetionNames;
using MySql.Data.MySqlClient;

namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    public class TopicConstruct
    {
        public FrameInFrame Frame;
        public string textIn;
        public int IDLaunch;
        public Form SpawnedBY;
        
        public TopicConstruct(String TextIn, int IDlaunch, FrameInFrame frame, Form SpawnedBy, WhereIAm whereIAm)
        {
            Frame = frame;
            IDLaunch = IDlaunch;
            textIn = TextIn;
            SpawnedBY = SpawnedBy;
        }
    }
    public partial class TopicElement : Form
    {
        private int IDLaunch = -1;
        private FrameInFrame frameInFrame;
        private Form spawnedBy;

        private WhereIAm where;
        public TopicElement(TopicConstruct Topic)
        {
            InitializeComponent();

            //Przekazywanie zmiennych lokalnych do zmiennych globalnych 
            {
                btn_Topic.Text = Topic.textIn;
                IDLaunch = Topic.IDLaunch;
                frameInFrame = Topic.Frame;
                spawnedBy = Topic.SpawnedBY;
            }

            if(frameInFrame.user.UserRighs != Enums.UserRighs.NormalUser)
            {
                //btn_Edit.Visible = false;
                btn_Topic.ContextMenuStrip = contextMenuStrip1;
            }
            else
            {
                btn_Topic.ContextMenuStrip = null;
            }
        }

        private void btn_Topic_Click(object sender, EventArgs e)
        {
            if(frameInFrame.user.UserRighs == UserRighs.Admin || frameInFrame.user.UserRighs == UserRighs.Editor)
            {
                ///Editor or admin 
                ///Kiedy użytkownik administracyjny kliknie w przycisk
                ///

                AddSection addSection = new AddSection(where);
                addSection.ShowDialog();

                frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.MainSubcjectPage(frameInFrame, where));
            }
            else
            {
                ///Normal user
                ///Kiedy normalny użytkownik kliknie w przycisk 
                ///

                ///Przegląd tematów i zadań sekcji
                ///

                frameInFrame.ChangeForm(new MaturaHelper.UserInterface.NormalUser.AllSubTopics(frameInFrame, where));
                
            }

            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //Otwiera Menu
            OpenMenu();
        }

        private void zadanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dodaj zadanie
        }

        

        private void usunSekcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Tutaj trzeba doprowadzić ID row w taveli 
            Helper.DelateSection(ID);
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.MainSubcjectPage(frameInFrame, where));

        }

        private void otwórzMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Otwórz menu
            OpenMenu();
        }

        private void OpenMenu()
        {
            FrameInFrame frame = new FrameInFrame();
            //MessageBox.Show("ID="+ID +  "MySqlID ="+ mySqlID);

            //mySqlID to chyba BID
            frame.ChangeForm(new MaturaHelper.UserInterface.Main.SubjectMain.Elements.TopicSettings(frame, ID, mySqlID));
            frame.ShowDialog();
            frameInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.MainSubcjectPage(frameInFrame, where));
        }

        private void podsekcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTopic newTopic = new NewTopic(ID);
            newTopic.ShowDialog();
        }
    }
}
