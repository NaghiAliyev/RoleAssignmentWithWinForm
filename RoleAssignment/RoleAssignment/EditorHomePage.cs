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
    public partial class EditorHomePage : Form
    {
        public EditorHomePage(Editor currentEditor)
        {
            InitializeComponent();
            this.currentEditor = currentEditor;
        }
        //Global variables
        Editor currentEditor;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        //Form events
        private void EditorHomePage_Load(object sender, EventArgs e)
        {
            lblHello.Text = $"Salamlar ,{currentEditor.FirstName.Trim()}!";
            Center(pnlContent,this);
        }

        private void EditorHomePage_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, this);
        }
    }
}
