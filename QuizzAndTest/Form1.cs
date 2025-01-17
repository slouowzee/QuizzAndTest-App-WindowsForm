using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbb_diff.Items.Add("Facile");
            cbb_diff.Items.Add("Moyen");
            cbb_diff.Items.Add("Difficile");
            cbb_diff.Items.Add("Enfer");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "Bonjour ";
            if (txt_nom.Text != "" && txt_prenom.Text != "")
            {
                result += $"{txt_prenom.Text} {txt_nom.Text}. \r\n La difficultés sélectionnée est {cbb_diff.SelectedItem}.";
                txt_afficher.Text = result;
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs nom et prénom.", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_diff.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                cbb_diff.Font = new Font(cbb_diff.Font, FontStyle.Bold);
                txt_afficher.Font = new Font(txt_afficher.Font, FontStyle.Bold);
                txt_nom.Font = new Font(txt_nom.Font, FontStyle.Bold);
                txt_prenom.Font = new Font(txt_prenom.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(191, 192, 255);
                cbb_diff.Font = new Font(cbb_diff.Font, FontStyle.Regular);
                txt_afficher.Font = new Font(txt_afficher.Font, FontStyle.Regular);
                txt_nom.Font = new Font(txt_nom.Font, FontStyle.Regular);
                txt_prenom.Font = new Font(txt_prenom.Font, FontStyle.Regular);
            }
        }
    }
}
