using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoleAssignment
{
    public partial class AdminPage : Form
    {
        public AdminPage(Admin currentAdmin)
        {
            InitializeComponent();
            this.currentAdmin = currentAdmin;
        }
        //Global Variables
        Admin currentAdmin;
        //-----------------------
        //Methods 

        //-----------------------
        //Form element's events
        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnBackToLogin_Click(sender, e);
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void lblHomePage_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            AdminHomePage homePage = new AdminHomePage(currentAdmin) 
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(homePage);
            homePage.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            lblHomePage_Click(sender, e);
        }

        private void lblEditors_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            AdminEditorsPage editorPage = new AdminEditorsPage()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(editorPage);
            editorPage.Show();
        }

    }
}
