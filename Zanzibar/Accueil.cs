using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zanzibar
{
    public partial class Accueil : Form
    {       
        public Accueil()
        {
            InitializeComponent();
        }
        private void Accueil_Load(object sender, EventArgs e)
        {
            validerChampsJoueurs();
        }

        private void buttonReglement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-La partie se joue en 3 tours " +
                "\n1 - L'ordre des joueurs qui lancent les dés fonctionnent par ordre (J1, J2...)" +
                "\n2 - Après brassage de dés, un joueur gagne un certain nombre de points selon les faces du dés." +
                "\n3 - Le numéro 1 donne 100 points et le numéro 6, 60 points." +
                "\n4 - Puis pour chaque autre face du dés le numéro octroie les points correspondant (2 donne 2 points, 3 donne 3 points...)." +
                "\n5 - Le gagnant est celui avec le plus de points après les 3 tours." +
                "\n" +
                "\n-Bonne partie!", "Réglement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter le jeu?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBoxNbJoueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            validerChampsJoueurs();
        }
        
        private void comboBoxNbJoueurs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void validerChampsJoueurs()
        {
            int nbJoueurs = Convert.ToInt32(comboBoxNbJoueurs.SelectedItem);
            bool champsRemplis = true;

            if (comboBoxNbJoueurs.SelectedIndex == -1)
            {
                errorProviderNbjoueurs.SetError(comboBoxNbJoueurs, "Nombre de joueurs obligatoire!");
                champsRemplis = false;
            }
            else
            {
                errorProviderNbjoueurs.SetError(comboBoxNbJoueurs, "");
            }

            if (nbJoueurs >= 1)
            {
                labelJ1.Visible = true;
                textBoxJ1.Visible = true;

                if (string.IsNullOrWhiteSpace(textBoxJ1.Text))
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ1, "Nom du joueur 1 obligatoire");
                    champsRemplis = false;
                }
                else
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ1, "");
                }
            }
            else
            {
                labelJ1.Visible = false;
                textBoxJ1.Visible = false;
            }

            if (nbJoueurs >= 2)
            {
                labelJ2.Visible = true;
                textBoxJ2.Visible = true;

                if (string.IsNullOrWhiteSpace(textBoxJ2.Text))
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ2, "Nom du joueur 2 obligatoire");
                    champsRemplis = false;
                }
                else
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ2, "");
                }
            }
            else
            {
                labelJ2.Visible = false;
                textBoxJ2.Visible = false;
            }

            if (nbJoueurs >= 3)
            {
                labelJ3.Visible = true;
                textBoxJ3.Visible = true;

                if (string.IsNullOrWhiteSpace(textBoxJ3.Text))
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ3, "Nom du joueur 3 obligatoire");
                    champsRemplis = false;
                }
                else
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ3, "");
                }
            }
            else
            {
                labelJ3.Visible = false;
                textBoxJ3.Text = string.Empty;
                textBoxJ3.Visible = false;
            }

            if (nbJoueurs >= 4)
            {
                labelJ4.Visible = true;
                textBoxJ4.Visible = true;

                if (string.IsNullOrWhiteSpace(textBoxJ4.Text))
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ4, "Nom du joueur 4 obligatoire");
                    champsRemplis = false;
                }
                else
                {
                    errorProviderNomsJoueurs.SetError(textBoxJ4, "");
                }
            }
            else
            {
                labelJ4.Visible = false;
                textBoxJ4.Visible = false;
                textBoxJ4.Text = string.Empty;
            }

            buttonDemarrer.Enabled = champsRemplis;
        }

        private void textBoxJ1_TextChanged(object sender, EventArgs e)
        {
            validerChampsJoueurs();
        }

        private void textBoxJ2_TextChanged(object sender, EventArgs e)
        {
            validerChampsJoueurs();
        }

        private void textBoxJ3_TextChanged(object sender, EventArgs e)
        {
            validerChampsJoueurs();
        }

        private void textBoxJ4_TextChanged(object sender, EventArgs e)
        {
            validerChampsJoueurs();
        }

        private void textBoxJ1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char touche = e.KeyChar;

            if (Char.IsLetter(touche) || Char.IsControl(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxJ2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char touche = e.KeyChar;

            if (Char.IsLetter(touche) || Char.IsControl(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxJ3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char touche = e.KeyChar;

            if (Char.IsLetter(touche) || Char.IsControl(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxJ4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char touche = e.KeyChar;

            if (Char.IsLetter(touche) || Char.IsControl(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void buttonDemarrer_Click(object sender, EventArgs e)
        {
            List<Joueur> joueurs = new List<Joueur>
            {
                new Joueur(textBoxJ1.Text, 1, 0),
                new Joueur(textBoxJ2.Text, 2, 0),
                new Joueur(textBoxJ3.Text, 3, 0),
                new Joueur(textBoxJ4.Text, 4, 0)
            };

            joueurs.RemoveAll(joueur => string.IsNullOrWhiteSpace(joueur.nomJoueur));

            Partie maPartie = new Partie(joueurs.Count, 3, joueurs, 1);

            Jeu jeu = new Jeu(maPartie);
            jeu.ShowDialog();
        }

        private void buttonMeilleursPointages_Click(object sender, EventArgs e)
        {
            richTextBoxMeilleursPointages.Text = richTextBoxMeilleursPointages.Text + Environment.NewLine + Jeu.meilleursPointages.ToString();
        }
    }
}
