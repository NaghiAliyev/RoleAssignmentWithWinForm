using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoleAssignment
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage(Admin currentAdmin)
        {
            InitializeComponent();
            this.currentAdmin = currentAdmin;
        }
        //
        Admin currentAdmin;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        //Form events
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                currentAdmin.Username = tbUsername.Text.Trim();
                currentAdmin.Password = tbPassword.Text.Trim();
                db.Entry(currentAdmin).State = EntityState.Modified;
                MessageBox.Show("Dəyişilmə uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);
                db.SaveChanges();
            }
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            tbUsername.Text = currentAdmin.Username;
            tbEmail.Text = currentAdmin.Email;
            tbEmail.Enabled = false;
            tbPassword.Text = currentAdmin.Password;
            Center(pnlContent,this);
        }

        private void AdminHomePage_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, this);
        }
    }
}
