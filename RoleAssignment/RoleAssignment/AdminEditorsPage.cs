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
    public partial class AdminEditorsPage : Form
    {
        public AdminEditorsPage()
        {
            InitializeComponent();
        }
        //Global Variables
        Editor editor = new Editor();
        string suggestedSurname;

        //----------------------------------
        //Methods
        private void Center(Panel inner, Control outer)
        {
            inner.Left = (outer.Width - inner.Width) / 2;
        }

        private void ClearInputs()
        {
            tbEmail.Clear();
            tbFirstName.Clear();
            tbSurname.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            mtbPhone.Clear();
            foreach (Control authority in gbAuthorities.Controls)
            {
                if (authority is CheckBox)
                {
                    CheckBox checkBox = authority as CheckBox;
                    checkBox.Checked = false;
                }
            }
            btnSave.Text = "Əlavə et";
            btnRemove.Enabled = false;
            editor.ID = 0;
        }
        
        private void GetNewData()
        {
            editor.Email = tbEmail.Text.Trim();
            editor.FirstName = tbFirstName.Text.Trim();
            editor.LastName = tbSurname.Text.Trim();
            editor.Username = tbUsername.Text.Trim();
            editor.Password = tbPassword.Text.Trim();
            editor.Phone = mtbPhone.Text.Trim();
            bool[] inputAuthorities = new bool[4];
            int counter = 0;
            foreach (Control authority in gbAuthorities.Controls)
            {
                if (authority is CheckBox)
                {
                    CheckBox checkBox = authority as CheckBox;
                    inputAuthorities[counter++] = checkBox.Checked;
                }
            }
            editor.CanCreate = inputAuthorities[0];
            editor.CanRead = inputAuthorities[1];
            editor.CanUpdate = inputAuthorities[2];
            editor.CanDelete = inputAuthorities[3];
        }

        private void FillInputs()
        {
            tbEmail.Text = editor.Email;
            tbFirstName.Text = editor.FirstName;
            tbSurname.Text = editor.LastName;
            tbUsername.Text = editor.Username;
            tbPassword.Text = editor.Password;
            mtbPhone.Text = editor.Phone;
            bool[] editorAuthorities =
            {
                editor.CanCreate,
                editor.CanRead,
                editor.CanUpdate,
                editor.CanDelete
            };
            int counter = 0;
            foreach (Control authority in gbAuthorities.Controls)
            {
                if (authority is CheckBox)
                {
                    CheckBox checkBox = authority as CheckBox;
                    checkBox.Checked = editorAuthorities[counter++];
                }
            }
        }

        private void PopulateDGV()
        {
            dgvEditors.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvEditors.DataSource = db.Editors.ToList<Editor>();
            }
        }
        //----------------------------------
        // 
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void AdminEditorsPage_Load(object sender, EventArgs e)
        {
            Center(pnlContent, pnlActions);
            ClearInputs();
            PopulateDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GetNewData();
                using (DBEntities db = new DBEntities())
                {
                    if (editor.ID == 0)
                    {
                        db.Editors.Add(editor);
                        MessageBox.Show("Əlavə etmə uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);
                    }
                    else
                    {
                        db.Entry(editor).State = EntityState.Modified;
                        MessageBox.Show("Dəyişilmə uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);
                    }
                    db.SaveChanges();
                }
                ClearInputs();
                PopulateDGV();
            }
            catch (DbEntityValidationException exception)
            {
                MessageBox.Show("Əlavə etmə uğursuz oldu!", "Bildiriş", MessageBoxButtons.OK);
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
            if (dgvEditors.CurrentRow.Index != -1)
            {
                editor.ID = Convert.ToInt32(dgvEditors.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    editor = db.Editors.Where(x => x.ID == editor.ID).FirstOrDefault();
                    FillInputs();
                }
                btnSave.Text = "Dəyiş";
                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{editor.FirstName} adlı istifadəçini sistemdən silmək istədiyinizə əminsinizmi?","Sorğu",MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(editor);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Editors.Attach(editor);
                    }
                    db.Editors.Remove(editor);
                    db.SaveChanges();
                    PopulateDGV();
                    ClearInputs();
                    MessageBox.Show("Seçilmiş istifadəçi sistemdən silindi!","Bildiriş");
                }
            }
        }

        private void AdminEditorsPage_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, pnlActions);
        }
    }
}
