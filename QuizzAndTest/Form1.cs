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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "" && txt_prenom.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs nom et prénom.", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2 jeu = new Form2();
                jeu.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_diff.SelectedItem.ToString() == "Enfer")
            {
                this.BackColor = Color.Red;
                cbb_diff.Font = new Font(cbb_diff.Font, FontStyle.Bold);
                txt_nom.Font = new Font(txt_nom.Font, FontStyle.Bold);
                txt_prenom.Font = new Font(txt_prenom.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(192, 192, 255);
                cbb_diff.Font = new Font(cbb_diff.Font, FontStyle.Regular);
                txt_nom.Font = new Font(txt_nom.Font, FontStyle.Regular);
                txt_prenom.Font = new Font(txt_prenom.Font, FontStyle.Regular);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
