//Copyright Mateusz Bernacki. All Rights Reserved.
//Copyright© 2022 Mateusz Bernacki

//API PortalEDU
using MaturaHelper.Enums;
using MaturaHelper.SQLconnetionNames;

//API SYSYTEM
using System;
using System.Data;
using System.Windows.Forms;

//API MySQL
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MaturaHelper.UserInterface.Main.SubjectMain.Elements
{
    public partial class TopicSettings : Form
    {
        /// <summary>
        /// Obiekt klasy okna
        /// </summary>
        public FrameInFrame fframeInFrame;

        /// <summary>
        /// ID obecnego 
        /// </summary>
        public int ID;

        /// <summary>
        /// 
        /// </summary>
        public int CellID;

        List<SubTopic> AddedFormsInPanel = new List<SubTopic>();

        /// <summary>
        /// Funkcja, służąca do dodawania kolenych okienek do panelu - FLP_AllTopicsToSection
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Belonging"></param>
        /// <param name="cellID"></param>
        public void AddForm(string name, int Belonging, int cellID)
        {
            SubTopic topicElement = new SubTopic(name, Belonging, cellID, fframeInFrame);
            topicElement.TopLevel = false;
            topicElement.FormBorderStyle = FormBorderStyle.None;
            topicElement.Dock = DockStyle.Top;
            FLP_AllTopicsToSection.Controls.Add(topicElement);
            FLP_AllTopicsToSection.Tag = topicElement;
            topicElement.Show();
            AddedFormsInPanel.Add(topicElement);

        }
        /// <summary>
        /// Konstruktor klasy, przeznaczony "strikte" pod resetowanie strony, po dodaniu nowego podzbioru
        /// </summary>
        /// <param name="topicForm"></param>
        /// <param name="id"></param>
        public TopicSettings(TopicSettings topicForm, int id)
        {
            //Koniecznie na początku, spawnuje wszystkie obiekty forma
            InitializeComponent();

            ///Nadanie niezaktualizowanych wartości do zaktualizowanego okna 
            ///Chodzi o to, aby po aktualizacji okna z tematami, ustawienia
            ///strony pozostały takie same
            chb_UserCanSee.Checked = topicForm.chb_UserCanSee.Checked;
            TB_SectionName.Text = topicForm.TB_SectionName.Text;
            fframeInFrame = topicForm.fframeInFrame;

            ///Odpowiada za połączenie się ze serwerem, uzupełnia je wartościami 
            ///z klasy "SQLConnetion"
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

            try
            {
                //Otwiera połączenie z bazą danych 
                connection.Open();
                try
                {
                    ///Ułożenie żądania do bazy danych 
                    ///SELECT * FROM nazwaBazyDanych WHERE BID='x';
                    ///Gdzie to nazwaBazyDanych to 
                    ///BID - belonging ID - id, do którego przynależy dany podzbiór
                    String querryV2 = "SELECT * FROM " + SQLConnetion.Scopes + " WHERE BID=" + id.ToString() + ";";

                    MySqlDataAdapter adapterV2 = new MySqlDataAdapter(querryV2, connection);

                    //Tworzenie i uzupełnianie tabeli o wybrane dane z bazy danych
                    DataTable dTableV2 = new DataTable();
                    adapterV2.Fill(dTableV2);

                    //Dodaje okna do panelu z okienkami danych zbiorów 
                    foreach (DataRow dr in dTableV2.Rows)
                    {
                        AddForm(dr[SQLConnetion.SectionName].ToString(), (int)dr["ID"], topicForm.CellID);
                    }
                }
                catch
                {
                    //Informacja o błędzie (błąd podczas pobierania danych)
                    MessageBox.Show("Niestety podczas pobierania danych z bazy wystąpił błąd, przepraszamy");
                }
            }
            catch
            {
                //Informacja o błędzie (Brak dostępu do bazy danych / brak internetu)
                MessageBox.Show("Przperaszamy, niestety nie udało nam się połączyć z usługami PortalEDU, spróbój ponownie później");
            }
            finally
            {
                //Zamyka połącznie z bazą danych 
                connection.Close();
            }
        }

        /// <summary>
        /// Prawidłowo stosowany, jest to podstawowy konstruktor
        /// </summary>
        /// <param name="frameInFrame"></param>
        /// <param name="Belonging"></param>
        /// <param name="cellID"></param>
        public TopicSettings(FrameInFrame frameInFrame, int Belonging, int cellID)
        {
            //Koniecznie na początku, spawnuje wszystkie obiekty forma
            InitializeComponent();

            //Ustawianie zmiennych na podstawie parametrów 
            fframeInFrame = frameInFrame;
            ID = Belonging;
            CellID = cellID;

            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

            try
            {
                //Otwiera połączenie z bazą danych 
                connection.Open();

                try
                {

                }
                catch
                {

                }
            }
            catch
            {

            }
            finally
            {

            }
            

            ///Stworzenie żądania do bazy danych 
            ///SELECT * FROM zakresy WHERE ID='x'; gdzie to :
            ///zakresy - tabela w bazie danych 
            ///ID - identyfikator danego podzakresu, przechowywanego w tabeli 
            String querry = "SELECT * FROM "+ SQLConnetion.Scopes + " WHERE ID='" + ID + "';";


            MySqlDataAdapter adapter = new MySqlDataAdapter(querry, connection);

            //Tworzy i uzupełnia tabelę na podstawie wybrabranych danych z tabeli z bazy danych 
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);

            ///Pobiera pierwszy wiersz z tabeli(to zazwyczaj on będzie tego czego dzukamy,
            ///tymbardziej jak mamy A_I na kolumnie w tabeli)
            DataRow dataRow = dTable.Rows[0];

            //Uzupełnia textbox o wartość z bazy danych 
            TB_SectionName.Text = dataRow["nazwazakresu"].ToString();

            ///Ustawia checkbox NUCS - Normal User Can See
            ///Jeśli jeden to true 
            ///Jeśli inne to false
            if ((int)dataRow["NUCS"] == 1)
            {
                chb_UserCanSee.Checked = true;
            }
            else
            {
                chb_UserCanSee.Checked = false;
            }

            String querryV2 = "SELECT * FROM " + SQLConnetion.Scopes + " WHERE BID="+ ID.ToString() +";";

            MySqlDataAdapter adapterV2 = new MySqlDataAdapter(querryV2, connection);

            DataTable dTableV2 = new DataTable();
            adapterV2.Fill(dTableV2);

            foreach(DataRow dr in dTableV2.Rows)
            {
                AddForm(dr[SQLConnetion.SectionName].ToString(), (int)dr["ID"], cellID);
            }

            connection.Close();
        }

        private void btn_Ready_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

            connection.Open();

            int CanUserSee = -1;
            if(chb_UserCanSee.Checked == true)
            {
                CanUserSee = 1;
            }
            else
            {
                CanUserSee = 0;
            }
            String Command = "UPDATE " + SQLConnetion.Scopes + " SET NUCS='" + CanUserSee.ToString() + "', NazwaZakresu='" + TB_SectionName.Text + "' WHERE ID= '" + (int)ID + "'";
            MySqlCommand cmd = new MySqlCommand(Command, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Dokonano zmiany");
            fframeInFrame.Close();
        }

        private void btn_AddTopic_Click(object sender, EventArgs e)
        {
            NewTopic newTopic = new NewTopic(ID);
            newTopic.ShowDialog();

            fframeInFrame.ChangeForm(new MaturaHelper.UserInterface.Main.SubjectMain.Elements.TopicSettings(this, ID));
        }

        private void SearchFor(string TextIn)
        {

            foreach(SubTopic form in AddedFormsInPanel)
            {
                form.Close();
            }
            int cellID = CellID;
            MySqlConnection connection = new MySqlConnection("server = " + SQLConnetion.Server +
            "; userid = " + SQLConnetion.UserID +
            "; password = " + SQLConnetion.PassWord +
            " ; database = " + SQLConnetion.DataBase + ";");

            connection.Open();

            ///Stworzenie żądania do bazy danych 
            ///SELECT * FROM zakresy WHERE ID='x'; gdzie to :
            ///zakresy - tabela w bazie danych 
            ///ID - identyfikator danego podzakresu, przechowywanego w tabeli 
            String querry = "SELECT * FROM " + SQLConnetion.Scopes + " WHERE ID='" + ID + "';";


            MySqlDataAdapter adapter = new MySqlDataAdapter(querry, connection);

            //Tworzy i uzupełnia tabelę na podstawie wybrabranych danych z tabeli z bazy danych 
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);

            ///Pobiera pierwszy wiersz z tabeli(to zazwyczaj on będzie tego czego dzukamy,
            ///tymbardziej jak mamy A_I na kolumnie w tabeli)
            
            DataRow dataRow = dTable.Rows[0];
            
                

                //Uzupełnia textbox o wartość z bazy danych 
                TB_SectionName.Text = dataRow["nazwazakresu"].ToString();

                ///Ustawia checkbox NUCS - Normal User Can See
                ///Jeśli jeden to true 
                ///Jeśli inne to false
                if ((int)dataRow["NUCS"] == 1)
                {
                    chb_UserCanSee.Checked = true;
                }
                else
                {
                    chb_UserCanSee.Checked = false;
                }

                String querryV2 = "SELECT * FROM " + SQLConnetion.Scopes + " SELECT CHARINDEX(" + TextIn + "IN );";

                MySqlDataAdapter adapterV2 = new MySqlDataAdapter(querryV2, connection);

                DataTable dTableV2 = new DataTable();
                adapterV2.Fill(dTableV2);

                foreach (DataRow dr in dTableV2.Rows)
                {
                    AddForm(dr[SQLConnetion.SectionName].ToString(), (int)dr["ID"], cellID);
                }
            
            
                connection.Close();
            
            

            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchFor(textBox1.Text);
        }
    }
}
