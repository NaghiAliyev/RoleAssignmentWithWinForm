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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Global Variables 
        Admin admin = new Admin();
        Editor currentEditor;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        private bool IsAdmin()
        {
            using (DBEntities db = new DBEntities())
            {
                try
                {
                    admin = db.Admins.Where(x => x.Email == tbEmail.Text.Trim()).FirstOrDefault();
                }
                catch (Exception exception)
                {
                    //MessageBox.Show(exception.Message);
                    MessageBox.Show("Gözlənilməz xəta!", "Xəta");
                }
                bool isExist = db.Admins.Any(x => x.Email.Trim() == tbEmail.Text.Trim());
                if (isExist)
                {
                    return true;
                }
                return false;
            }
        }

        private bool IsEditor()
        {
            using (DBEntities db = new DBEntities())
            {
                try
                {
                    currentEditor = db.Editors.Where(x => x.Email == tbEmail.Text.Trim()).FirstOrDefault();
                }
                catch (Exception exception)
                {
                    //MessageBox.Show(exception.Message);
                    MessageBox.Show("Gözlənilməz xəta!", "Xəta");
                }
                bool isExist = db.Editors.Any(x => x.Email.Trim() == tbEmail.Text.Trim());
                if (isExist)
                {
                    return true;
                }
                return false;
            }
        }
        
        // Form element's events
        private void Login_Load(object sender, EventArgs e)
        {
            //IsAdmin();
            Center(pnlContent, this);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '●';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tbEmailText = tbEmail.Text.Trim();
            string tbPasswordText = tbPassword.Text.Trim();
            if (IsAdmin())
            {
                if (admin.Password.Trim() == tbPasswordText && admin.Email.Trim() == tbEmailText)
                {
                    AdminPage adminPage = new AdminPage(admin);
                    this.Hide();
                    adminPage.Show();
                }
                else
                {
                    MessageBox.Show("Şifrə və ya E-Poçt yalnışdır!");
                }
            }
            else if (IsEditor())
            {
                if (currentEditor.Password.Trim() == tbPasswordText && currentEditor.Email.Trim() == tbEmailText)
                {
                    EditorPage ep = new EditorPage(currentEditor);
                    MessageBox.Show(currentEditor.FirstName.Trim() + " " + currentEditor.LastName.Trim());
                    this.Hide();
                    ep.Show();
                }
                else
                {
                    MessageBox.Show("Şifrə və ya E-Poçt yalnışdır!");
                }
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, this);
        }
    }
}
