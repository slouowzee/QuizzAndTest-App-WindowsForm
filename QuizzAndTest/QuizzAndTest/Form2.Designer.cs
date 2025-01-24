namespace QuizzAndTest
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.repbox = new System.Windows.Forms.GroupBox();
            this.rep3 = new System.Windows.Forms.CheckBox();
            this.rep1 = new System.Windows.Forms.CheckBox();
            this.rep2 = new System.Windows.Forms.CheckBox();
            this.rep5 = new System.Windows.Forms.CheckBox();
            this.rep4 = new System.Windows.Forms.CheckBox();
            this.ques = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.TextBox();
            this.titre = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.temps = new System.Windows.Forms.Label();
            this.tempsbox = new System.Windows.Forms.TextBox();
            this.repbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // repbox
            // 
            this.repbox.Controls.Add(this.rep3);
            this.repbox.Controls.Add(this.rep1);
            this.repbox.Controls.Add(this.rep2);
            this.repbox.Controls.Add(this.rep5);
            this.repbox.Controls.Add(this.rep4);
            this.repbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repbox.Location = new System.Drawing.Point(28, 232);
            this.repbox.Name = "repbox";
            this.repbox.Size = new System.Drawing.Size(350, 195);
            this.repbox.TabIndex = 12;
            this.repbox.TabStop = false;
            this.repbox.Text = "Réponses Possibles";
            // 
            // rep3
            // 
            this.rep3.AutoSize = true;
            this.rep3.Location = new System.Drawing.Point(36, 89);
            this.rep3.Name = "rep3";
            this.rep3.Size = new System.Drawing.Size(92, 20);
            this.rep3.TabIndex = 4;
            this.rep3.Text = "Réponse 3";
            this.rep3.UseVisualStyleBackColor = true;
            // 
            // rep1
            // 
            this.rep1.AutoSize = true;
            this.rep1.Location = new System.Drawing.Point(36, 21);
            this.rep1.Name = "rep1";
            this.rep1.Size = new System.Drawing.Size(92, 20);
            this.rep1.TabIndex = 3;
            this.rep1.Text = "Réponse 1";
            this.rep1.UseVisualStyleBackColor = true;
            // 
            // rep2
            // 
            this.rep2.AutoSize = true;
            this.rep2.Location = new System.Drawing.Point(36, 54);
            this.rep2.Name = "rep2";
            this.rep2.Size = new System.Drawing.Size(92, 20);
            this.rep2.TabIndex = 2;
            this.rep2.Text = "Réponse 2";
            this.rep2.UseVisualStyleBackColor = true;
            // 
            // rep5
            // 
            this.rep5.AutoSize = true;
            this.rep5.Location = new System.Drawing.Point(36, 160);
            this.rep5.Name = "rep5";
            this.rep5.Size = new System.Drawing.Size(92, 20);
            this.rep5.TabIndex = 1;
            this.rep5.Text = "Réponse 5";
            this.rep5.UseVisualStyleBackColor = true;
            // 
            // rep4
            // 
            this.rep4.AutoSize = true;
            this.rep4.Location = new System.Drawing.Point(36, 124);
            this.rep4.Name = "rep4";
            this.rep4.Size = new System.Drawing.Size(92, 20);
            this.rep4.TabIndex = 0;
            this.rep4.Text = "Réponse 4";
            this.rep4.UseVisualStyleBackColor = true;
            // 
            // ques
            // 
            this.ques.AutoSize = true;
            this.ques.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ques.Location = new System.Drawing.Point(40, 97);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(86, 20);
            this.ques.TabIndex = 11;
            this.ques.Text = "Question 1";
            // 
            // question
            // 
            this.question.Enabled = false;
            this.question.Location = new System.Drawing.Point(28, 122);
            this.question.Margin = new System.Windows.Forms.Padding(5);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.ShortcutsEnabled = false;
            this.question.Size = new System.Drawing.Size(350, 89);
            this.question.TabIndex = 10;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(167, 11);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(470, 73);
            this.titre.TabIndex = 9;
            this.titre.Text = "Quizz And Test";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(297, 417);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 16;
            this.submit.Text = "Valider";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(610, 190);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(162, 151);
            this.picbox.TabIndex = 15;
            this.picbox.TabStop = false;
            // 
            // temps
            // 
            this.temps.AutoSize = true;
            this.temps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temps.Location = new System.Drawing.Point(429, 97);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(96, 20);
            this.temps.TabIndex = 14;
            this.temps.Text = "Temps Total";
            // 
            // tempsbox
            // 
            this.tempsbox.Enabled = false;
            this.tempsbox.Location = new System.Drawing.Point(412, 122);
            this.tempsbox.Margin = new System.Windows.Forms.Padding(5);
            this.tempsbox.Multiline = true;
            this.tempsbox.Name = "tempsbox";
            this.tempsbox.ShortcutsEnabled = false;
            this.tempsbox.Size = new System.Drawing.Size(360, 45);
            this.tempsbox.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.repbox);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.question);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.tempsbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.repbox.ResumeLayout(false);
            this.repbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox repbox;
        private System.Windows.Forms.CheckBox rep3;
        private System.Windows.Forms.CheckBox rep1;
        private System.Windows.Forms.CheckBox rep2;
        private System.Windows.Forms.CheckBox rep5;
        private System.Windows.Forms.CheckBox rep4;
        private System.Windows.Forms.Label ques;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label temps;
        private System.Windows.Forms.TextBox tempsbox;
    }
}