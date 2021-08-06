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
    public partial class EditorPage : Form
    {
        public EditorPage(Editor currentEditor)
        {
            InitializeComponent();
            this.currentEditor = currentEditor;
        }
        //Global Variables
        Editor currentEditor;

        //Form element's events
        private void EditorPage_FormClosing(object sender, FormClosingEventArgs e)
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
            EditorHomePage homePage = new EditorHomePage(currentEditor)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(homePage);
            homePage.Show();
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            EditorCustomersPage editorPage = new EditorCustomersPage(currentEditor)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(editorPage);
            editorPage.Show();
        }

        private void EditorPage_Load(object sender, EventArgs e)
        {
            lblHomePage_Click(sender, e);
        }

    }
}
