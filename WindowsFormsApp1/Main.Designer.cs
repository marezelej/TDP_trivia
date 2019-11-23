namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewTest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCreateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpentDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpentDBAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpentDBImport = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSessionRanking = new System.Windows.Forms.ToolStripMenuItem();
            this.mMySessions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.userData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewTest
            // 
            this.btnNewTest.Location = new System.Drawing.Point(54, 140);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(207, 38);
            this.btnNewTest.TabIndex = 1;
            this.btnNewTest.Text = "Iniciar Examen";
            this.btnNewTest.UseVisualStyleBackColor = true;
            this.btnNewTest.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sesionesToolStripMenuItem,
            this.menuLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCreateUser,
            this.mUsers,
            this.mChangePassword});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // mCreateUser
            // 
            this.mCreateUser.Name = "mCreateUser";
            this.mCreateUser.Size = new System.Drawing.Size(226, 26);
            this.mCreateUser.Text = "Nuevo";
            // 
            // mUsers
            // 
            this.mUsers.Name = "mUsers";
            this.mUsers.Size = new System.Drawing.Size(226, 26);
            this.mUsers.Text = "Administrar";
            // 
            // mChangePassword
            // 
            this.mChangePassword.Name = "mChangePassword";
            this.mChangePassword.Size = new System.Drawing.Size(226, 26);
            this.mChangePassword.Text = "Cambiar Contraseña";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpentDB});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 24);
            this.toolStripMenuItem1.Text = "Preguntas";
            // 
            // mOpentDB
            // 
            this.mOpentDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpentDBAdmin,
            this.mOpentDBImport});
            this.mOpentDB.Name = "mOpentDB";
            this.mOpentDB.Size = new System.Drawing.Size(153, 26);
            this.mOpentDB.Text = "OpentDB";
            // 
            // mOpentDBAdmin
            // 
            this.mOpentDBAdmin.Name = "mOpentDBAdmin";
            this.mOpentDBAdmin.Size = new System.Drawing.Size(193, 26);
            this.mOpentDBAdmin.Text = "Administrar";
            // 
            // mOpentDBImport
            // 
            this.mOpentDBImport.Name = "mOpentDBImport";
            this.mOpentDBImport.Size = new System.Drawing.Size(193, 26);
            this.mOpentDBImport.Text = "Importar Datos";
            // 
            // sesionesToolStripMenuItem
            // 
            this.sesionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSessionRanking,
            this.mMySessions});
            this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.sesionesToolStripMenuItem.Text = "Sesiones";
            // 
            // mSessionRanking
            // 
            this.mSessionRanking.Name = "mSessionRanking";
            this.mSessionRanking.Size = new System.Drawing.Size(174, 26);
            this.mSessionRanking.Text = "Ranking";
            // 
            // mMySessions
            // 
            this.mMySessions.Name = "mMySessions";
            this.mMySessions.Size = new System.Drawing.Size(174, 26);
            this.mMySessions.Text = "Mis sesiones";
            // 
            // menuLogOut
            // 
            this.menuLogOut.Name = "menuLogOut";
            this.menuLogOut.Size = new System.Drawing.Size(52, 24);
            this.menuLogOut.Text = "Salir";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(54, 184);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(207, 38);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mejor puntaje:";
            // 
            // userData
            // 
            this.userData.Controls.Add(this.label5);
            this.userData.Controls.Add(this.label6);
            this.userData.Controls.Add(this.label3);
            this.userData.Controls.Add(this.label4);
            this.userData.Controls.Add(this.label2);
            this.userData.Controls.Add(this.label1);
            this.userData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userData.Location = new System.Drawing.Point(20, 42);
            this.userData.Name = "userData";
            this.userData.Size = new System.Drawing.Size(281, 88);
            this.userData.TabIndex = 6;
            this.userData.TabStop = false;
            this.userData.Text = "Martín Lejman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "26 segundos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tiempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "10 preguntas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "200 puntos";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 234);
            this.Controls.Add(this.userData);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNewTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Trivia";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.userData.ResumeLayout(false);
            this.userData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCreateUser;
        private System.Windows.Forms.ToolStripMenuItem mUsers;
        private System.Windows.Forms.ToolStripMenuItem mChangePassword;
        private System.Windows.Forms.ToolStripMenuItem menuLogOut;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSessionRanking;
        private System.Windows.Forms.ToolStripMenuItem mMySessions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox userData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mOpentDB;
        private System.Windows.Forms.ToolStripMenuItem mOpentDBAdmin;
        private System.Windows.Forms.ToolStripMenuItem mOpentDBImport;
    }
}

