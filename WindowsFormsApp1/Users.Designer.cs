namespace WindowsFormsApp1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userStateActive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.userFileNumber = new System.Windows.Forms.TextBox();
            this.userStateInactive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.userType = new System.Windows.Forms.ComboBox();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opentDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misSesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.lastName,
            this.fileNumber});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(698, 366);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
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
            // userFileNumber
            // 
            this.userFileNumber.Location = new System.Drawing.Point(68, 78);
            this.userFileNumber.Name = "userFileNumber";
            this.userFileNumber.Size = new System.Drawing.Size(278, 22);
            this.userFileNumber.TabIndex = 6;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Legajo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // userType
            // 
            this.userType.FormattingEnabled = true;
            this.userType.Location = new System.Drawing.Point(68, 48);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(278, 24);
            this.userType.TabIndex = 10;
            // 
            // name
            // 
            this.name.Text = "Nombre";
            // 
            // lastName
            // 
            this.lastName.Text = "Apellido";
            // 
            // fileNumber
            // 
            this.fileNumber.Text = "Legajo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sesionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.administrarToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opentDBToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 24);
            this.toolStripMenuItem1.Text = "Preguntas";
            // 
            // opentDBToolStripMenuItem
            // 
            this.opentDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem1,
            this.importarDatosToolStripMenuItem});
            this.opentDBToolStripMenuItem.Name = "opentDBToolStripMenuItem";
            this.opentDBToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.opentDBToolStripMenuItem.Text = "OpentDB";
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(193, 26);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            // 
            // importarDatosToolStripMenuItem
            // 
            this.importarDatosToolStripMenuItem.Name = "importarDatosToolStripMenuItem";
            this.importarDatosToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.importarDatosToolStripMenuItem.Text = "Importar Datos";
            // 
            // sesionesToolStripMenuItem
            // 
            this.sesionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem,
            this.misSesionesToolStripMenuItem});
            this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.sesionesToolStripMenuItem.Text = "Sesiones";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // misSesionesToolStripMenuItem
            // 
            this.misSesionesToolStripMenuItem.Name = "misSesionesToolStripMenuItem";
            this.misSesionesToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.misSesionesToolStripMenuItem.Text = "Mis sesiones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agregar Usuario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 578);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 25);
            this.button4.TabIndex = 12;
            this.button4.Text = "Eliminar Usuario";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 615);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Users";
            this.Text = "Administrar Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader fileNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opentDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misSesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}