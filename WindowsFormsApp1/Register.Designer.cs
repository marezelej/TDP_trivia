namespace WindowsFormsApp1
{
    partial class Register
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
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 305);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 32);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(100, 43);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(289, 22);
            this.firstName.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(100, 80);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(289, 22);
            this.lastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // fileNumber
            // 
            this.fileNumber.Location = new System.Drawing.Point(100, 117);
            this.fileNumber.Name = "fileNumber";
            this.fileNumber.Size = new System.Drawing.Size(289, 22);
            this.fileNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Legajo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repeatPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(35, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autenticación";
            // 
            // repeatPassword
            // 
            this.repeatPassword.Location = new System.Drawing.Point(9, 90);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.PasswordChar = '*';
            this.repeatPassword.Size = new System.Drawing.Size(339, 22);
            this.repeatPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repetir Contraseña:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(9, 45);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(339, 22);
            this.password.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña:";
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(330, 305);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(94, 32);
            this.accept.TabIndex = 8;
            this.accept.Text = "Registrar";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 349);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Name = "Register";
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button accept;
    }
}