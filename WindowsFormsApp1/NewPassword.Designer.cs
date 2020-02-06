namespace TriviaGUI
{
    partial class NewPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.PWInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPWInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPWInput2 = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su contraseña actual";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PWInput
            // 
            this.PWInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWInput.Location = new System.Drawing.Point(12, 30);
            this.PWInput.Name = "PWInput";
            this.PWInput.Size = new System.Drawing.Size(193, 22);
            this.PWInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su nueva contraseña";
            // 
            // NewPWInput
            // 
            this.NewPWInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPWInput.Location = new System.Drawing.Point(12, 79);
            this.NewPWInput.Name = "NewPWInput";
            this.NewPWInput.PasswordChar = '*';
            this.NewPWInput.Size = new System.Drawing.Size(193, 22);
            this.NewPWInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repita su nueva contraseña";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // NewPWInput2
            // 
            this.NewPWInput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPWInput2.Location = new System.Drawing.Point(12, 130);
            this.NewPWInput2.Name = "NewPWInput2";
            this.NewPWInput2.PasswordChar = '*';
            this.NewPWInput2.Size = new System.Drawing.Size(193, 22);
            this.NewPWInput2.TabIndex = 5;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(120, 158);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(82, 28);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.NewPWInput2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPWInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PWInput);
            this.Controls.Add(this.label1);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PWInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPWInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPWInput2;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button button1;
    }
}