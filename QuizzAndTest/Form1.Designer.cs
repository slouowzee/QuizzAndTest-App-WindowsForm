﻿namespace QuizzAndTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.cbb_diff = new System.Windows.Forms.ComboBox();
            this.txt_diff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.White;
            this.btn_valider.Location = new System.Drawing.Point(259, 284);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(82, 19);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.White;
            this.txt_nom.Location = new System.Drawing.Point(231, 99);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(151, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom";
            // 
            // txt_prenom
            // 
            this.txt_prenom.BackColor = System.Drawing.Color.White;
            this.txt_prenom.Location = new System.Drawing.Point(231, 151);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(151, 20);
            this.txt_prenom.TabIndex = 6;
            // 
            // cbb_diff
            // 
            this.cbb_diff.BackColor = System.Drawing.Color.White;
            this.cbb_diff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_diff.FormattingEnabled = true;
            this.cbb_diff.Location = new System.Drawing.Point(231, 203);
            this.cbb_diff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_diff.Name = "cbb_diff";
            this.cbb_diff.Size = new System.Drawing.Size(151, 21);
            this.cbb_diff.TabIndex = 7;
            this.cbb_diff.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_diff
            // 
            this.txt_diff.AutoSize = true;
            this.txt_diff.Location = new System.Drawing.Point(128, 206);
            this.txt_diff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_diff.Name = "txt_diff";
            this.txt_diff.Size = new System.Drawing.Size(48, 13);
            this.txt_diff.TabIndex = 8;
            this.txt_diff.Text = "Difficulté";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txt_diff);
            this.Controls.Add(this.cbb_diff);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_valider);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Mon 1er formulaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox cbb_diff;
        private System.Windows.Forms.Label txt_diff;
    }
}

