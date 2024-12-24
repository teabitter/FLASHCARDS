namespace FLASHCARDS
{
    partial class Application
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.listBoxFlashcards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(264, 47);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(405, 222);
            this.textBoxQuestion.TabIndex = 3;
            this.textBoxQuestion.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(408, 294);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 43);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(264, 360);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(405, 222);
            this.textBoxAnswer.TabIndex = 5;
            this.textBoxAnswer.TabStop = false;
            // 
            // listBoxFlashcards
            // 
            this.listBoxFlashcards.FormattingEnabled = true;
            this.listBoxFlashcards.ItemHeight = 16;
            this.listBoxFlashcards.Location = new System.Drawing.Point(822, 141);
            this.listBoxFlashcards.Name = "listBoxFlashcards";
            this.listBoxFlashcards.Size = new System.Drawing.Size(349, 404);
            this.listBoxFlashcards.TabIndex = 6;
            this.listBoxFlashcards.SelectedIndexChanged += new System.EventHandler(this.listBoxFlashcards_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insert Question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insert Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(945, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1255, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFlashcards);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxQuestion);
            this.ForeColor = System.Drawing.Color.Pink;
            this.Name = "Application";
            this.Text = "Flashcard App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.ListBox listBoxFlashcards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

