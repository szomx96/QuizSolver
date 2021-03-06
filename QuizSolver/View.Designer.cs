﻿namespace QuizSolver
{
    partial class View
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.answer4 = new QuizSolver.Answer();
            this.answer3 = new QuizSolver.Answer();
            this.answer2 = new QuizSolver.Answer();
            this.answer1 = new QuizSolver.Answer();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(29, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(701, 107);
            this.textBox1.TabIndex = 5;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 16;
            this.listBoxQuestions.Location = new System.Drawing.Point(776, 148);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(202, 244);
            this.listBoxQuestions.TabIndex = 6;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(29, 470);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(119, 50);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "PREVIOUS";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(611, 470);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(119, 50);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Enabled = false;
            this.buttonCheck.Location = new System.Drawing.Point(776, 470);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(202, 50);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxScore
            // 
            this.textBoxScore.Enabled = false;
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxScore.Location = new System.Drawing.Point(776, 86);
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(202, 54);
            this.textBoxScore.TabIndex = 10;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(776, 408);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(202, 54);
            this.buttonImport.TabIndex = 11;
            this.buttonImport.Text = "OPEN QUIZ";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTimer.Location = new System.Drawing.Point(776, 33);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 25);
            this.labelTimer.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // answer4
            // 
            this.answer4.IsChecked = false;
            this.answer4.IsEnabled = false;
            this.answer4.Location = new System.Drawing.Point(390, 295);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(355, 117);
            this.answer4.TabIndex = 15;
            // 
            // answer3
            // 
            this.answer3.IsChecked = false;
            this.answer3.IsEnabled = false;
            this.answer3.Location = new System.Drawing.Point(390, 161);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(355, 117);
            this.answer3.TabIndex = 14;
            // 
            // answer2
            // 
            this.answer2.IsChecked = false;
            this.answer2.IsEnabled = false;
            this.answer2.Location = new System.Drawing.Point(29, 295);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(355, 117);
            this.answer2.TabIndex = 13;
            // 
            // answer1
            // 
            this.answer1.IsChecked = false;
            this.answer1.IsEnabled = false;
            this.answer1.Location = new System.Drawing.Point(29, 161);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(355, 117);
            this.answer1.TabIndex = 12;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 549);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.textBox1);
            this.Name = "View";
            this.Text = "QuizSolver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Answer answer1;
        private Answer answer2;
        private Answer answer3;
        private Answer answer4;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

