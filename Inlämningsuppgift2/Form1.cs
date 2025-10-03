
using Inlämningsuppgift2.Classes;
using System.Drawing.Drawing2D;

namespace Inlämningsuppgift2
{
    public partial class Form1Login : Form
    {
        public User currentUser;
        public Form1Login()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
        }

        private void button1Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username and Password cannot be empty!");
                return;
            }

            if (ValidateUser())
            {
                //Start Game!
                Form3Game formGame = new Form3Game();
                Game.Instance.user = currentUser;
                formGame.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your account was not found, please register to play the game!");
            }

        }
        private bool ValidateUser()
        {

            List<User> users = new List<User>();
            users = DataHandler.Load();
            foreach (User user in users)
            {
                if (user.UserName.ToLower() == textBoxName.Text.ToLower())
                {
                    if (user.UserPassword.ToLower() == textBoxPassword.Text.ToLower())
                    {
                        currentUser = user;
                        return true;
                    }
                }
            }
            return false;
        }

        private void button2Register_Click(object sender, EventArgs e)
        {
            Form2Register formRegister = new Form2Register();
            formRegister.ShowDialog();
        }
    }
}
