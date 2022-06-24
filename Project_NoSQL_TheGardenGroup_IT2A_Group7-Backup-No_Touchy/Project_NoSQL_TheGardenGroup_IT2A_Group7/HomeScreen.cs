using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheGardenGroupLogic;
using TheGardenGroupModel;

namespace Project_NoSQL_TheGardenGroup_IT2A_Group7
{
    public partial class TheGradenGroupHome : Form
    {
        private User user;

        public TheGradenGroupHome(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            PrintTests();
        }

        private void ShowPanel(string panelName)
        {
            if (panelName == "AdminIncidents")
            {

            } else
            {
                
            }
            //Has to be further implemented
        }

        private void PrintTests() //Change to PrintTickets (is different for both permissions)
        {
            //Test_Service testService = new Test_Service();
            //List<Ticket> tickets = testService.ReadAllTests();
            //foreach (Ticket test in tickets)
            //{
            //    ListViewItem li = new ListViewItem(test.Id.ToString(), 0);
            //    li.SubItems.Add(test.Name);
            //    li.SubItems.Add(test.Age.ToString());
            //    lvlIncidents.Items.Add(li);
            //}
        }

        private void btnSubmitNewTicket_Click(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new NewTicketForm();
            newTicketForm.ShowDialog();
        }
    }
}
