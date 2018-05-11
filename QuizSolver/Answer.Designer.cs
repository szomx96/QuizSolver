namespace QuizSolver
{
    partial class Answer
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxAnswer = new System.Windows.Forms.CheckBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxAnswer
            // 
            this.checkBoxAnswer.AutoSize = true;
            this.checkBoxAnswer.Location = new System.Drawing.Point(0, 15);
            this.checkBoxAnswer.Name = "checkBoxAnswer";
            this.checkBoxAnswer.Size = new System.Drawing.Size(18, 17);
            this.checkBoxAnswer.TabIndex = 0;
            this.checkBoxAnswer.UseVisualStyleBackColor = true;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Location = new System.Drawing.Point(24, 15);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(314, 81);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.checkBoxAnswer);
            this.Name = "Answer";
            this.Size = new System.Drawing.Size(355, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
    }
}
