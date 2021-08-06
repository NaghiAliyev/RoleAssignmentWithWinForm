using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoleAssignment
{
    public partial class EditorCustomersPage : Form
    {
        public EditorCustomersPage(Editor currentEditor)
        {
            InitializeComponent();
            this.currentEditor = currentEditor;
        }
        //Global Variables
        Customer customer = new Customer();
        string suggestedSurname;
        string message;
        Editor currentEditor;
        bool canDelete;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        private void ClearInputs()
        {
            tbFirstName.Clear();
            tbSurname.Clear();
            tbUsername.Clear();
            mtbPhone.Clear();
            btnSave.Text = "Əlavə et";
            btnRemove.Enabled = false;
            customer.ID = 0;
            if (!currentEditor.CanUpdate)
            {
                btnSave.Enabled = true;
                btnSave.Show();
            }
        }

        private void GetNewData()
        {
            customer.FirstName = tbFirstName.Text.Trim();
            customer.LastName = tbSurname.Text.Trim();
            customer.Username = tbUsername.Text.Trim();
            customer.Phone = mtbPhone.Text.Trim();
        }

        private void FillInputs()
        {
            tbFirstName.Text = customer.FirstName;
            tbSurname.Text = customer.LastName;
            tbUsername.Text = customer.Username;
            mtbPhone.Text = customer.Phone;
            
        }

        private void PopulateDGV()
        {
            dgvCustomers.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvCustomers.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void CheckAuthorities()
        {
            if (!currentEditor.CanCreate)
            {
                btnSave.Enabled = false;
                btnSave.Hide();
            }
            if (!currentEditor.CanRead)
            {
                dgvCustomers.Hide();
            }
            if (!currentEditor.CanDelete)
            {
                btnRemove.Enabled = false;
                btnRemove.Hide();
            }
        }

        //  Form element's events
        private void btnClear_Click(object sender, EventArgs e)
        {
            CheckAuthorities();
            ClearInputs();
        }

        private void EditorCustomersPage_Load(object sender, EventArgs e)
        {
            CheckAuthorities();
            ClearInputs();
            PopulateDGV();
            Center(pnlContent,pnlActions);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                GetNewData();
                using (DBEntities db = new DBEntities())
                {
                    if (customer.ID == 0)
                    {
                        db.Customers.Add(customer);
                        message = "Əlavə etmə";
                    }
                    else
                    {
                        db.Entry(customer).State = EntityState.Modified;
                        message = "Dəyişmə";
                    }
                    db.SaveChanges();
                }
                ClearInputs();
                PopulateDGV();
                MessageBox.Show($"{message} uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);
            }
            catch (DbEntityValidationException exception)
            {
                MessageBox.Show($"{message} uğursuz oldu!", "Bildiriş", MessageBoxButtons.OK);
            }
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            string inputFirstName = tbFirstName.Text.Trim();
            string inputLastName = tbSurname.Text.Trim();
            suggestedSurname = inputFirstName.ToLower() + inputLastName.ToLower();
            tbUsername.Text = suggestedSurname;
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            string inputFirstName = tbFirstName.Text.Trim();
            string inputLastName = tbSurname.Text.Trim();
            suggestedSurname = inputFirstName.ToLower() + inputLastName.ToLower();
            tbUsername.Text = suggestedSurname;
        }

        private void dgvEditors_DoubleClick(object sender, EventArgs e)
        {
            if (!currentEditor.CanCreate)
            {
                btnSave.Enabled = true;
                btnSave.Show();
            }
            if (!currentEditor.CanUpdate)
            {
                btnSave.Enabled = false;
                btnSave.Hide();
            }
            if (dgvCustomers.CurrentRow.Index != -1)
            {
                customer.ID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    customer = db.Customers.Where(x => x.ID == customer.ID).FirstOrDefault();
                    FillInputs();
                }
                btnSave.Text = "Dəyiş";
                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{customer.FirstName} adlı istifadəçini sistemdən silmək istədiyinizə əminsinizmi?", "Sorğu", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(customer);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Customers.Attach(customer);
                    }
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    PopulateDGV();
                    ClearInputs();
                    MessageBox.Show("Seçilmiş istifadəçi sistemdən silindi!", "Bildiriş");
                }
            }
        }

        private void EditorCustomersPage_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, pnlActions);
        }
    }
}
