
namespace RoleAssignment
{
    partial class EditorCustomersPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Controls.Add(this.mtbPhone);
            this.pnlContent.Controls.Add(this.lblUsername);
            this.pnlContent.Controls.Add(this.lblPhone);
            this.pnlContent.Controls.Add(this.btnRemove);
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.lblFirstName);
            this.pnlContent.Controls.Add(this.btnClear);
            this.pnlContent.Controls.Add(this.lblSurname);
            this.pnlContent.Controls.Add(this.tbSurname);
            this.pnlContent.Controls.Add(this.tbFirstName);
            this.pnlContent.Controls.Add(this.tbUsername);
            this.pnlContent.Location = new System.Drawing.Point(17, 17);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(635, 276);
            this.pnlContent.TabIndex = 18;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(289, 128);
            this.mtbPhone.Mask = "(+99999) 000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(187, 27);
            this.mtbPhone.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(161, 98);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "İstifadəçi adı:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(161, 134);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 21);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Telefon:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(265, 194);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 30);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Əlavə et";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(161, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(41, 21);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Adı:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(379, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Təmizlə";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(161, 61);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 21);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Soyadı:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(289, 61);
            this.tbSurname.MaxLength = 40;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(187, 27);
            this.tbSurname.TabIndex = 6;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(289, 26);
            this.tbFirstName.MaxLength = 40;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(187, 27);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(289, 95);
            this.tbUsername.MaxLength = 80;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(187, 27);
            this.tbUsername.TabIndex = 7;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FrirstName,
            this.LastName,
            this.Username,
            this.Phone});
            this.dgvCustomers.Location = new System.Drawing.Point(40, 318);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(599, 195);
            this.dgvCustomers.TabIndex = 17;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.dgvEditors_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "CustomerID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FrirstName
            // 
            this.FrirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FrirstName.DataPropertyName = "FirstName";
            this.FrirstName.HeaderText = "Adı";
            this.FrirstName.Name = "FrirstName";
            this.FrirstName.ReadOnly = true;
            this.FrirstName.Width = 21;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Soyadı";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 21;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "İsifadəçi adı";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 21;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Telefon nömrəsi";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 21;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.pnlContent);
            this.pnlActions.Location = new System.Drawing.Point(0, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(671, 300);
            this.pnlActions.TabIndex = 19;
            // 
            // EditorCustomersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(673, 532);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditorCustomersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorCustomersPage";
            this.Load += new System.EventHandler(this.EditorCustomersPage_Load);
            this.Resize += new System.EventHandler(this.EditorCustomersPage_Resize);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Panel pnlActions;
    }
}