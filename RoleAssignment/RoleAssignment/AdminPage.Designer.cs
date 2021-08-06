
namespace RoleAssignment
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblEditors = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlMenu.Controls.Add(this.lblEditors);
            this.pnlMenu.Controls.Add(this.lblHomePage);
            this.pnlMenu.Controls.Add(this.btnBackToLogin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(217, 615);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblEditors
            // 
            this.lblEditors.AutoSize = true;
            this.lblEditors.Location = new System.Drawing.Point(40, 203);
            this.lblEditors.Name = "lblEditors";
            this.lblEditors.Size = new System.Drawing.Size(122, 21);
            this.lblEditors.TabIndex = 2;
            this.lblEditors.Text = "Editor əlavə et";
            this.lblEditors.Click += new System.EventHandler(this.lblEditors_Click);
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Location = new System.Drawing.Point(49, 151);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(91, 21);
            this.lblHomePage.TabIndex = 1;
            this.lblHomePage.Text = "Əsas səhifə";
            this.lblHomePage.Click += new System.EventHandler(this.lblHomePage_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToLogin.BackgroundImage")));
            this.btnBackToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackToLogin.Location = new System.Drawing.Point(13, 13);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(49, 47);
            this.btnBackToLogin.TabIndex = 0;
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.SlateGray;
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(217, 0);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(803, 615);
            this.pnlActions.TabIndex = 0;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Label lblEditors;
        private System.Windows.Forms.Label lblHomePage;
    }
}