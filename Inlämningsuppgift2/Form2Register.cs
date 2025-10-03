using Inlämningsuppgift2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2
{
    public partial class Form2Register : Form
    {
        public Form2Register()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username and Password cannot be empty!");
                return;
            }

            RegisterNewUser();
        }

        private void RegisterNewUser()
        {
            User user = new User();
            user.UserName = textBoxName.Text;
            user.UserPassword = textBoxPassword.Text;

            DataHandler.Save(user);
            MessageBox.Show("Your acount was created!");
            this.Close();
        }
    }
}
