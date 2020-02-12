using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Contract;
using TP_Final.Trivia;
using System.Windows.Forms;

namespace TriviaGUI
{
    public partial class Users : Form
    {
        IUserFacade iUsersFacade = new UserFacade();
        public Users()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Register registerWindow = new Register(iUsersFacade);
            registerWindow.ShowDialog();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            userFileNumber.Clear();
            UserFirstName.Clear();
            UserLastName.Clear();
            userType.SelectedIndex = 0;
            userStateActive.Checked = false;
            userStateInactive.Checked = false;
        }

        private void UserFileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserStateActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserStateInactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }

        private void UserFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
