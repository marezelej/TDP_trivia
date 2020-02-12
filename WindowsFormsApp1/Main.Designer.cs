namespace TriviaGUI
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
            this.mUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpentDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpentDBAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSessionRanking = new System.Windows.Forms.ToolStripMenuItem();
            this.mMySessions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userData = new System.Windows.Forms.GroupBox();
            this.lBestTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lBestQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lBestScore = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.userData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewTest
            // 
            this.btnNewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTest.Location = new System.Drawing.Point(232, 136);
            this.btnNewTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(155, 31);
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
            this.sesionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUsers,
            this.mChangePassword});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // mUsers
            // 
            this.mUsers.Name = "mUsers";
            this.mUsers.Size = new System.Drawing.Size(182, 22);
            this.mUsers.Text = "Administrar";
            this.mUsers.Click += new System.EventHandler(this.MUsers_Click);
            // 
            // mChangePassword
            // 
            this.mChangePassword.Name = "mChangePassword";
            this.mChangePassword.Size = new System.Drawing.Size(182, 22);
            this.mChangePassword.Text = "Cambiar Contraseña";
            this.mChangePassword.Click += new System.EventHandler(this.MChangePassword_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpentDB});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem1.Text = "Preguntas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // mOpentDB
            // 
            this.mOpentDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpentDBAdmin});
            this.mOpentDB.Name = "mOpentDB";
            this.mOpentDB.Size = new System.Drawing.Size(122, 22);
            this.mOpentDB.Text = "OpentDB";
            // 
            // mOpentDBAdmin
            // 
            this.mOpentDBAdmin.Name = "mOpentDBAdmin";
            this.mOpentDBAdmin.Size = new System.Drawing.Size(136, 22);
            this.mOpentDBAdmin.Text = "Administrar";
            this.mOpentDBAdmin.Click += new System.EventHandler(this.MOpentDBAdmin_Click);
            // 
            // sesionesToolStripMenuItem
            // 
            this.sesionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSessionRanking,
            this.mMySessions});
            this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.sesionesToolStripMenuItem.Text = "Sesiones";
            // 
            // mSessionRanking
            // 
            this.mSessionRanking.Name = "mSessionRanking";
            this.mSessionRanking.Size = new System.Drawing.Size(140, 22);
            this.mSessionRanking.Text = "Ranking";
            this.mSessionRanking.Click += new System.EventHandler(this.MSessionRanking_Click);
            // 
            // mMySessions
            // 
            this.mMySessions.Name = "mMySessions";
            this.mMySessions.Size = new System.Drawing.Size(140, 22);
            this.mMySessions.Text = "Mis sesiones";
            this.mMySessions.Click += new System.EventHandler(this.MMySessions_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(15, 136);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(155, 31);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mejor puntaje:";
            // 
            // userData
            // 
            this.userData.Controls.Add(this.lBestTime);
            this.userData.Controls.Add(this.label6);
            this.userData.Controls.Add(this.lBestQuantity);
            this.userData.Controls.Add(this.label4);
            this.userData.Controls.Add(this.lBestScore);
            this.userData.Controls.Add(this.label1);
            this.userData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userData.Location = new System.Drawing.Point(15, 34);
            this.userData.Margin = new System.Windows.Forms.Padding(2);
            this.userData.Name = "userData";
            this.userData.Padding = new System.Windows.Forms.Padding(2);
            this.userData.Size = new System.Drawing.Size(373, 91);
            this.userData.TabIndex = 6;
            this.userData.TabStop = false;
            this.userData.Text = "Martín Lejman";
            this.userData.Enter += new System.EventHandler(this.UserData_Enter);
            // 
            // lBestTime
            // 
            this.lBestTime.AutoSize = true;
            this.lBestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestTime.Location = new System.Drawing.Point(154, 65);
            this.lBestTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBestTime.Name = "lBestTime";
            this.lBestTime.Size = new System.Drawing.Size(90, 17);
            this.lBestTime.TabIndex = 10;
            this.lBestTime.Text = "26 segundos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tiempo:";
            // 
            // lBestQuantity
            // 
            this.lBestQuantity.AutoSize = true;
            this.lBestQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestQuantity.Location = new System.Drawing.Point(154, 44);
            this.lBestQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBestQuantity.Name = "lBestQuantity";
            this.lBestQuantity.Size = new System.Drawing.Size(92, 17);
            this.lBestQuantity.TabIndex = 8;
            this.lBestQuantity.Text = "10 preguntas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
            // 
            // lBestScore
            // 
            this.lBestScore.AutoSize = true;
            this.lBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestScore.Location = new System.Drawing.Point(154, 23);
            this.lBestScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBestScore.Name = "lBestScore";
            this.lBestScore.Size = new System.Drawing.Size(79, 17);
            this.lBestScore.TabIndex = 6;
            this.lBestScore.Text = "200 puntos";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 177);
            this.Controls.Add(this.userData);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNewTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem mUsers;
        private System.Windows.Forms.ToolStripMenuItem mChangePassword;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSessionRanking;
        private System.Windows.Forms.ToolStripMenuItem mMySessions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox userData;
        private System.Windows.Forms.Label lBestTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lBestQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lBestScore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mOpentDB;
        private System.Windows.Forms.ToolStripMenuItem mOpentDBAdmin;
    }
}

