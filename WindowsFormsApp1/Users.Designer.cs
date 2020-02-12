namespace TriviaGUI
{
    partial class Users
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
            this.UsersGB = new System.Windows.Forms.GroupBox();
            this.UsersDGV = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FilterGB = new System.Windows.Forms.GroupBox();
            this.UserLastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.UserLastName = new System.Windows.Forms.TextBox();
            this.UserFirstName = new System.Windows.Forms.TextBox();
            this.userType = new System.Windows.Forms.ComboBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UserFileNumberLabel = new System.Windows.Forms.Label();
            this.userFileNumber = new System.Windows.Forms.TextBox();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.userStateInactive = new System.Windows.Forms.RadioButton();
            this.UserStateLabel = new System.Windows.Forms.Label();
            this.userStateActive = new System.Windows.Forms.RadioButton();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UsersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            this.FilterGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersGB
            // 
            this.UsersGB.Controls.Add(this.UsersDGV);
            this.UsersGB.Location = new System.Drawing.Point(9, 146);
            this.UsersGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersGB.Name = "UsersGB";
            this.UsersGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersGB.Size = new System.Drawing.Size(532, 319);
            this.UsersGB.TabIndex = 1;
            this.UsersGB.TabStop = false;
            this.UsersGB.Text = "Usuarios";
            // 
            // UsersDGV
            // 
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.FileNumber,
            this.Password,
            this.Active,
            this.Admin});
            this.UsersDGV.Location = new System.Drawing.Point(7, 17);
            this.UsersDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.RowHeadersWidth = 51;
            this.UsersDGV.RowTemplate.Height = 24;
            this.UsersDGV.Size = new System.Drawing.Size(521, 297);
            this.UsersDGV.TabIndex = 0;
            this.UsersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Apellido";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FileNumber
            // 
            this.FileNumber.HeaderText = "Legajo";
            this.FileNumber.MinimumWidth = 6;
            this.FileNumber.Name = "FileNumber";
            this.FileNumber.ReadOnly = true;
            this.FileNumber.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Contraseña";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // Active
            // 
            this.Active.HeaderText = "Activo";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.Width = 60;
            // 
            // Admin
            // 
            this.Admin.HeaderText = "Admin";
            this.Admin.MinimumWidth = 6;
            this.Admin.Name = "Admin";
            this.Admin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Admin.Width = 60;
            // 
            // FilterGB
            // 
            this.FilterGB.Controls.Add(this.UserLastNameLabel);
            this.FilterGB.Controls.Add(this.FirstNameLabel);
            this.FilterGB.Controls.Add(this.UserLastName);
            this.FilterGB.Controls.Add(this.UserFirstName);
            this.FilterGB.Controls.Add(this.userType);
            this.FilterGB.Controls.Add(this.CleanButton);
            this.FilterGB.Controls.Add(this.ApplyButton);
            this.FilterGB.Controls.Add(this.UserFileNumberLabel);
            this.FilterGB.Controls.Add(this.userFileNumber);
            this.FilterGB.Controls.Add(this.UserTypeLabel);
            this.FilterGB.Controls.Add(this.userStateInactive);
            this.FilterGB.Controls.Add(this.UserStateLabel);
            this.FilterGB.Controls.Add(this.userStateActive);
            this.FilterGB.Location = new System.Drawing.Point(9, 10);
            this.FilterGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterGB.Name = "FilterGB";
            this.FilterGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterGB.Size = new System.Drawing.Size(532, 132);
            this.FilterGB.TabIndex = 2;
            this.FilterGB.TabStop = false;
            this.FilterGB.Text = "Filtros";
            // 
            // UserLastNameLabel
            // 
            this.UserLastNameLabel.AutoSize = true;
            this.UserLastNameLabel.Location = new System.Drawing.Point(5, 112);
            this.UserLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLastNameLabel.Name = "UserLastNameLabel";
            this.UserLastNameLabel.Size = new System.Drawing.Size(47, 13);
            this.UserLastNameLabel.TabIndex = 14;
            this.UserLastNameLabel.Text = "Apellido:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(5, 90);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(47, 13);
            this.FirstNameLabel.TabIndex = 13;
            this.FirstNameLabel.Text = "Nombre:";
            // 
            // UserLastName
            // 
            this.UserLastName.Location = new System.Drawing.Point(56, 109);
            this.UserLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.Size = new System.Drawing.Size(210, 20);
            this.UserLastName.TabIndex = 12;
            this.UserLastName.TextChanged += new System.EventHandler(this.UserLastName_TextChanged);
            // 
            // UserFirstName
            // 
            this.UserFirstName.Location = new System.Drawing.Point(56, 86);
            this.UserFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserFirstName.Name = "UserFirstName";
            this.UserFirstName.Size = new System.Drawing.Size(210, 20);
            this.UserFirstName.TabIndex = 11;
            this.UserFirstName.TextChanged += new System.EventHandler(this.UserFirstName_TextChanged);
            // 
            // userType
            // 
            this.userType.FormattingEnabled = true;
            this.userType.Location = new System.Drawing.Point(56, 39);
            this.userType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(210, 21);
            this.userType.TabIndex = 10;
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(340, 109);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(92, 20);
            this.CleanButton.TabIndex = 9;
            this.CleanButton.Text = "Limpiar";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(436, 109);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(92, 20);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Aplicar";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UserFileNumberLabel
            // 
            this.UserFileNumberLabel.AutoSize = true;
            this.UserFileNumberLabel.Location = new System.Drawing.Point(4, 66);
            this.UserFileNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserFileNumberLabel.Name = "UserFileNumberLabel";
            this.UserFileNumberLabel.Size = new System.Drawing.Size(42, 13);
            this.UserFileNumberLabel.TabIndex = 8;
            this.UserFileNumberLabel.Text = "Legajo:";
            // 
            // userFileNumber
            // 
            this.userFileNumber.Location = new System.Drawing.Point(56, 63);
            this.userFileNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userFileNumber.Name = "userFileNumber";
            this.userFileNumber.Size = new System.Drawing.Size(210, 20);
            this.userFileNumber.TabIndex = 6;
            this.userFileNumber.TextChanged += new System.EventHandler(this.UserFileNumber_TextChanged);
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(4, 41);
            this.UserTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.UserTypeLabel.TabIndex = 7;
            this.UserTypeLabel.Text = "Tipo:";
            // 
            // userStateInactive
            // 
            this.userStateInactive.AutoSize = true;
            this.userStateInactive.Location = new System.Drawing.Point(111, 20);
            this.userStateInactive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userStateInactive.Name = "userStateInactive";
            this.userStateInactive.Size = new System.Drawing.Size(63, 17);
            this.userStateInactive.TabIndex = 6;
            this.userStateInactive.TabStop = true;
            this.userStateInactive.Text = "Inactivo";
            this.userStateInactive.UseVisualStyleBackColor = true;
            this.userStateInactive.CheckedChanged += new System.EventHandler(this.UserStateInactive_CheckedChanged);
            // 
            // UserStateLabel
            // 
            this.UserStateLabel.AutoSize = true;
            this.UserStateLabel.Location = new System.Drawing.Point(4, 22);
            this.UserStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserStateLabel.Name = "UserStateLabel";
            this.UserStateLabel.Size = new System.Drawing.Size(43, 13);
            this.UserStateLabel.TabIndex = 5;
            this.UserStateLabel.Text = "Estado:";
            // 
            // userStateActive
            // 
            this.userStateActive.AutoSize = true;
            this.userStateActive.Location = new System.Drawing.Point(56, 20);
            this.userStateActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userStateActive.Name = "userStateActive";
            this.userStateActive.Size = new System.Drawing.Size(55, 17);
            this.userStateActive.TabIndex = 4;
            this.userStateActive.TabStop = true;
            this.userStateActive.Text = "Activo";
            this.userStateActive.UseVisualStyleBackColor = true;
            this.userStateActive.CheckedChanged += new System.EventHandler(this.UserStateActive_CheckedChanged);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(436, 470);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(101, 20);
            this.AddUserButton.TabIndex = 11;
            this.AddUserButton.Text = "Agregar Usuario";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(330, 470);
            this.DeleteUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(101, 20);
            this.DeleteUserButton.TabIndex = 12;
            this.DeleteUserButton.Text = "Eliminar Usuario";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(16, 470);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(101, 20);
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "Refrescar";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 509);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.FilterGB);
            this.Controls.Add(this.UsersGB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Users";
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.Users_Load);
            this.UsersGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            this.FilterGB.ResumeLayout(false);
            this.FilterGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox UsersGB;
        private System.Windows.Forms.GroupBox FilterGB;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label UserFileNumberLabel;
        private System.Windows.Forms.TextBox userFileNumber;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.RadioButton userStateInactive;
        private System.Windows.Forms.Label UserStateLabel;
        private System.Windows.Forms.RadioButton userStateActive;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.DataGridView UsersDGV;
        private System.Windows.Forms.TextBox UserLastName;
        private System.Windows.Forms.TextBox UserFirstName;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label UserLastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}