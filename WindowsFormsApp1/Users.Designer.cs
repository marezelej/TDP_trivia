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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userFileNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userStateInactive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.userStateActive = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.FileNumber,
            this.Password,
            this.Active,
            this.Admin});
            this.dataGridView1.Location = new System.Drawing.Point(9, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.FileNumber.HeaderText = "legajo";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userType);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.userFileNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.userStateInactive);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.userStateActive);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // userType
            // 
            this.userType.FormattingEnabled = true;
            this.userType.Location = new System.Drawing.Point(68, 48);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(278, 24);
            this.userType.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Legajo:";
            // 
            // userFileNumber
            // 
            this.userFileNumber.Location = new System.Drawing.Point(68, 78);
            this.userFileNumber.Name = "userFileNumber";
            this.userFileNumber.Size = new System.Drawing.Size(278, 22);
            this.userFileNumber.TabIndex = 6;
            this.userFileNumber.TextChanged += new System.EventHandler(this.UserFileNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo:";
            // 
            // userStateInactive
            // 
            this.userStateInactive.AutoSize = true;
            this.userStateInactive.Location = new System.Drawing.Point(141, 25);
            this.userStateInactive.Name = "userStateInactive";
            this.userStateInactive.Size = new System.Drawing.Size(77, 21);
            this.userStateInactive.TabIndex = 6;
            this.userStateInactive.TabStop = true;
            this.userStateInactive.Text = "Inactivo";
            this.userStateInactive.UseVisualStyleBackColor = true;
            this.userStateInactive.CheckedChanged += new System.EventHandler(this.UserStateInactive_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado:";
            // 
            // userStateActive
            // 
            this.userStateActive.AutoSize = true;
            this.userStateActive.Location = new System.Drawing.Point(68, 25);
            this.userStateActive.Name = "userStateActive";
            this.userStateActive.Size = new System.Drawing.Size(67, 21);
            this.userStateActive.TabIndex = 4;
            this.userStateActive.TabStop = true;
            this.userStateActive.Text = "Activo";
            this.userStateActive.UseVisualStyleBackColor = true;
            this.userStateActive.CheckedChanged += new System.EventHandler(this.UserStateActive_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 545);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agregar Usuario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 25);
            this.button4.TabIndex = 12;
            this.button4.Text = "Eliminar Usuario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 583);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Users";
            this.Text = "Administrar Usuarios";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userFileNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton userStateInactive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton userStateActive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
    }
}