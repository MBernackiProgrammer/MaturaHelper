using MaturaHelper.BUser;
using System.Windows.Forms;

namespace MaturaHelper
{
    public partial class FrameInFrame : Form
    {
        /// <summary>
        /// obiekt klasy, w krórej znajdują się wszystkie dane apropo użytkownika tj. login hasło...
        /// </summary>
        public User user;

        /// <summary>
        /// Funkcja służy do zmiany formu w framie 
        /// </summary>
        /// <param name="ChangeTo">form na jaki zmienić</param>
        public void ChangeForm(Form ChangeTo)
        {
            ChangeTo.TopLevel = false;
            ChangeTo.FormBorderStyle = FormBorderStyle.None;
            ChangeTo.Dock = DockStyle.Fill;
            P_Frame.Controls.Add(ChangeTo);
            P_Frame.Tag = ChangeTo;
            ChangeTo.BringToFront();
            ChangeTo.Show();
            
        }
        
        public FrameInFrame()
        {
            InitializeComponent();
            ChangeForm(new MaturaHelper.UserInterface.Login.LoginPanel(this));
        }
    }
}
