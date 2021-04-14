namespace TriviaGUI
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.rAnswer1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rAnswer4 = new System.Windows.Forms.RadioButton();
            this.rAnswer3 = new System.Windows.Forms.RadioButton();
            this.rAnswer2 = new System.Windows.Forms.RadioButton();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.QuestionText = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.questionQuantityLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clickEnd = new System.Windows.Forms.Button();
            this.clickPrevious = new System.Windows.Forms.Button();
            this.clickNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.questionGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rAnswer1
            // 
            this.rAnswer1.AutoSize = true;
            this.rAnswer1.Location = new System.Drawing.Point(4, 22);
            this.rAnswer1.Margin = new System.Windows.Forms.Padding(2);
            this.rAnswer1.Name = "rAnswer1";
            this.rAnswer1.Size = new System.Drawing.Size(109, 22);
            this.rAnswer1.TabIndex = 0;
            this.rAnswer1.TabStop = true;
            this.rAnswer1.Text = "Respuesta 1";
            this.rAnswer1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rAnswer4);
            this.groupBox1.Controls.Add(this.rAnswer3);
            this.groupBox1.Controls.Add(this.rAnswer2);
            this.groupBox1.Controls.Add(this.rAnswer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(731, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respuestas";
            // 
            // rAnswer4
            // 
            this.rAnswer4.AutoSize = true;
            this.rAnswer4.Location = new System.Drawing.Point(4, 88);
            this.rAnswer4.Margin = new System.Windows.Forms.Padding(2);
            this.rAnswer4.Name = "rAnswer4";
            this.rAnswer4.Size = new System.Drawing.Size(109, 22);
            this.rAnswer4.TabIndex = 3;
            this.rAnswer4.TabStop = true;
            this.rAnswer4.Text = "Respuesta 4";
            this.rAnswer4.UseVisualStyleBackColor = true;
            // 
            // rAnswer3
            // 
            this.rAnswer3.AutoSize = true;
            this.rAnswer3.Location = new System.Drawing.Point(4, 66);
            this.rAnswer3.Margin = new System.Windows.Forms.Padding(2);
            this.rAnswer3.Name = "rAnswer3";
            this.rAnswer3.Size = new System.Drawing.Size(109, 22);
            this.rAnswer3.TabIndex = 2;
            this.rAnswer3.TabStop = true;
            this.rAnswer3.Text = "Respuesta 3";
            this.rAnswer3.UseVisualStyleBackColor = true;
            // 
            // rAnswer2
            // 
            this.rAnswer2.AutoSize = true;
            this.rAnswer2.Location = new System.Drawing.Point(4, 44);
            this.rAnswer2.Margin = new System.Windows.Forms.Padding(2);
            this.rAnswer2.Name = "rAnswer2";
            this.rAnswer2.Size = new System.Drawing.Size(109, 22);
            this.rAnswer2.TabIndex = 1;
            this.rAnswer2.TabStop = true;
            this.rAnswer2.Text = "Respuesta 2";
            this.rAnswer2.UseVisualStyleBackColor = true;
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.QuestionText);
            this.questionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionGroupBox.Location = new System.Drawing.Point(266, 10);
            this.questionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.questionGroupBox.Size = new System.Drawing.Size(474, 117);
            this.questionGroupBox.TabIndex = 2;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "Pregunta Número 1";
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Location = new System.Drawing.Point(4, 29);
            this.QuestionText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(223, 18);
            this.QuestionText.TabIndex = 0;
            this.QuestionText.Text = "¿Qué pregunta desea contestar?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.questionQuantityLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.timeLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(253, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sesión Actual";
            // 
            // questionQuantityLabel
            // 
            this.questionQuantityLabel.AutoSize = true;
            this.questionQuantityLabel.Location = new System.Drawing.Point(116, 84);
            this.questionQuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionQuantityLabel.Name = "questionQuantityLabel";
            this.questionQuantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.questionQuantityLabel.Size = new System.Drawing.Size(93, 18);
            this.questionQuantityLabel.TabIndex = 6;
            this.questionQuantityLabel.Text = "10 preguntas";
            this.questionQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cantidad:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(116, 52);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLabel.Size = new System.Drawing.Size(52, 18);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "20 seg";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 22);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 15);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clickEnd);
            this.groupBox5.Controls.Add(this.clickPrevious);
            this.groupBox5.Controls.Add(this.clickNext);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 401);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(731, 75);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acciones";
            // 
            // clickEnd
            // 
            this.clickEnd.Location = new System.Drawing.Point(177, 25);
            this.clickEnd.Margin = new System.Windows.Forms.Padding(2);
            this.clickEnd.Name = "clickEnd";
            this.clickEnd.Size = new System.Drawing.Size(121, 34);
            this.clickEnd.TabIndex = 2;
            this.clickEnd.Text = "Terminar";
            this.clickEnd.UseVisualStyleBackColor = true;
            this.clickEnd.Click += new System.EventHandler(this.clickEnd_Click);
            // 
            // clickPrevious
            // 
            this.clickPrevious.Enabled = false;
            this.clickPrevious.Location = new System.Drawing.Point(4, 25);
            this.clickPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.clickPrevious.Name = "clickPrevious";
            this.clickPrevious.Size = new System.Drawing.Size(154, 34);
            this.clickPrevious.TabIndex = 1;
            this.clickPrevious.Text = "Anterior Pregunta";
            this.clickPrevious.UseVisualStyleBackColor = true;
            this.clickPrevious.Click += new System.EventHandler(this.clickPrevious_Click);
            // 
            // clickNext
            // 
            this.clickNext.Location = new System.Drawing.Point(318, 25);
            this.clickNext.Margin = new System.Windows.Forms.Padding(2);
            this.clickNext.Name = "clickNext";
            this.clickNext.Size = new System.Drawing.Size(152, 34);
            this.clickNext.TabIndex = 0;
            this.clickNext.Text = "Siguiente Pregunta";
            this.clickNext.UseVisualStyleBackColor = true;
            this.clickNext.Click += new System.EventHandler(this.clickNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 486);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.questionGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Test";
            this.Text = "Trivia";
            this.Load += new System.EventHandler(this.Test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rAnswer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rAnswer4;
        private System.Windows.Forms.RadioButton rAnswer3;
        private System.Windows.Forms.RadioButton rAnswer2;
        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button clickEnd;
        private System.Windows.Forms.Button clickPrevious;
        private System.Windows.Forms.Button clickNext;
        private System.Windows.Forms.Label questionQuantityLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}