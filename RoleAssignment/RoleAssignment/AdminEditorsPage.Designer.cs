
namespace RoleAssignment
{
    partial class AdminEditorsPage
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbAuthorities = new System.Windows.Forms.GroupBox();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.cbRead = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvEditors = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.gbAuthorities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditors)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 15);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Poçt:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "İstifadəçi adı:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Parol:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 48);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(41, 21);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Adı:";
            // 
            // gbAuthorities
            // 
            this.gbAuthorities.Controls.Add(this.cbCreate);
            this.gbAuthorities.Controls.Add(this.cbRead);
            this.gbAuthorities.Controls.Add(this.cbUpdate);
            this.gbAuthorities.Controls.Add(this.cbDelete);
            this.gbAuthorities.Location = new System.Drawing.Point(372, 48);
            this.gbAuthorities.Name = "gbAuthorities";
            this.gbAuthorities.Size = new System.Drawing.Size(275, 139);
            this.gbAuthorities.TabIndex = 11;
            this.gbAuthorities.TabStop = false;
            this.gbAuthorities.Text = "Səlahiyyətlər";
            // 
            // cbCreate
            // 
            this.cbCreate.AutoSize = true;
            this.cbCreate.Location = new System.Drawing.Point(6, 38);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(148, 25);
            this.cbCreate.TabIndex = 0;
            this.cbCreate.Text = "Əlavə edə bilsin";
            this.cbCreate.UseVisualStyleBackColor = true;
            // 
            // cbRead
            // 
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(153, 38);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(120, 25);
            this.cbRead.TabIndex = 2;
            this.cbRead.Text = "Oxuya bilsin";
            this.cbRead.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(6, 94);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(116, 25);
            this.cbUpdate.TabIndex = 3;
            this.cbUpdate.Text = "Dəyişə bilsin";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(153, 94);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(92, 25);
            this.cbDelete.TabIndex = 1;
            this.cbDelete.Text = "Silə bilsin";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(151, 12);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(187, 27);
            this.tbEmail.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(151, 117);
            this.tbUsername.MaxLength = 80;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(187, 27);
            this.tbUsername.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(151, 151);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(187, 27);
            this.tbPassword.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(151, 48);
            this.tbFirstName.MaxLength = 40;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(187, 27);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Əlavə et";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(241, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 30);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvEditors
            // 
            this.dgvEditors.AllowUserToDeleteRows = false;
            this.dgvEditors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FrirstName,
            this.LastName,
            this.Username,
            this.Phone});
            this.dgvEditors.Location = new System.Drawing.Point(40, 311);
            this.dgvEditors.Name = "dgvEditors";
            this.dgvEditors.ReadOnly = true;
            this.dgvEditors.Size = new System.Drawing.Size(599, 195);
            this.dgvEditors.TabIndex = 15;
            this.dgvEditors.DoubleClick += new System.EventHandler(this.dgvEditors_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "EditorID";
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(355, 197);
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
            this.lblSurname.Location = new System.Drawing.Point(23, 83);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 21);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Soyadı:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(151, 83);
            this.tbSurname.MaxLength = 40;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(187, 27);
            this.tbSurname.TabIndex = 6;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(368, 18);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 21);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Telefon:";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(440, 12);
            this.mtbPhone.Mask = "(+99999) 000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(207, 27);
            this.mtbPhone.TabIndex = 10;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.pnlContent);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(672, 276);
            this.pnlActions.TabIndex = 16;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblEmail);
            this.pnlContent.Controls.Add(this.tbUsername);
            this.pnlContent.Controls.Add(this.mtbPhone);
            this.pnlContent.Controls.Add(this.tbPassword);
            this.pnlContent.Controls.Add(this.lblUsername);
            this.pnlContent.Controls.Add(this.tbEmail);
            this.pnlContent.Controls.Add(this.lblPhone);
            this.pnlContent.Controls.Add(this.tbFirstName);
            this.pnlContent.Controls.Add(this.btnRemove);
            this.pnlContent.Controls.Add(this.gbAuthorities);
            this.pnlContent.Controls.Add(this.lblPassword);
            this.pnlContent.Controls.Add(this.tbSurname);
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.lblSurname);
            this.pnlContent.Controls.Add(this.lblFirstName);
            this.pnlContent.Controls.Add(this.btnClear);
            this.pnlContent.Location = new System.Drawing.Point(8, 12);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(657, 261);
            this.pnlContent.TabIndex = 15;
            // 
            // AdminEditorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(672, 540);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.dgvEditors);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminEditorsPage";
            this.Text = "AdminEditorsPage";
            this.Load += new System.EventHandler(this.AdminEditorsPage_Load);
            this.Resize += new System.EventHandler(this.AdminEditorsPage_Resize);
            this.gbAuthorities.ResumeLayout(false);
            this.gbAuthorities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditors)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbAuthorities;
        private System.Windows.Forms.CheckBox cbCreate;
        private System.Windows.Forms.CheckBox cbRead;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvEditors;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Panel pnlContent;
    }
}