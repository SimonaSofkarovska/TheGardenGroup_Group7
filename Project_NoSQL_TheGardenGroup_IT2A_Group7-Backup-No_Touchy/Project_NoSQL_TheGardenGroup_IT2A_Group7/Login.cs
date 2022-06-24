using System;
using System.Windows.Forms;
using TheGardenGroupModel;

namespace Project_NoSQL_TheGardenGroup_IT2A_Group7
{
    public partial class Login : Form
    {
        User loggedUser;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Test code, has to be changed to actually have a user...
            TheGradenGroupHome mainWindow = new TheGradenGroupHome(loggedUser);

            this.Hide();
            mainWindow.ShowDialog();

            txtUsername.Clear();
            txtPassword.Clear();

            this.Show();
        }
    }
}
