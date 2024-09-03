using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;

namespace Zanzibar
{
    public partial class Jeu : Form
    {
        private static List<ImageJeu> listImage = new List<ImageJeu>
        {
            new ImageJeu(1, "Face 1", 100, "Rouge_1.png"),
            new ImageJeu(2, "Face 2", 2, "Rouge_2.png"),
            new ImageJeu(3, "Face 3", 3, "Rouge_3.png"),
            new ImageJeu(4, "Face 4", 4, "Rouge_4.png"),
            new ImageJeu(5, "Face 5", 5, "Rouge_5.png"),
            new ImageJeu(6, "Face 6", 60, "Rouge_6.png")
        };

        Thread jeu;
        string chemin = "../../fichiers/";
        Random desAleatoire = new Random();

        Partie maPartie;
        private int joueurActuel = 0;
        public static int meilleursPointages;

        public Jeu(Partie pMaPartie)
        {
            this.maPartie = pMaPartie;
            InitializeComponent();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            if (maPartie.nbJoueurs == 2)
            {
                labelPointageJ1.Text = maPartie.joueurs[0].nomJoueur;
                labelPointageJ2.Text = maPartie.joueurs[1].nomJoueur;
                toolStripTextBoxNomJ3.Enabled = false;
                toolStripTextBoxNomJ4.Enabled = false;
            }

            else if (maPartie.nbJoueurs == 3)
            {
                labelPointageJ1.Text = maPartie.joueurs[0].nomJoueur;
                labelPointageJ2.Text = maPartie.joueurs[1].nomJoueur;
                labelPointageJ3.Text = maPartie.joueurs[2].nomJoueur;
                toolStripTextBoxNomJ4.Enabled = false;
            }

            else if (maPartie.nbJoueurs == 4)
            {
                labelPointageJ1.Text = maPartie.joueurs[0].nomJoueur;
                labelPointageJ2.Text = maPartie.joueurs[1].nomJoueur;
                labelPointageJ3.Text = maPartie.joueurs[2].nomJoueur;
                labelPointageJ4.Text = maPartie.joueurs[3].nomJoueur;
            }

            labelGagnantJ1.Visible = false;
            labelGagnantJ2.Visible = false;
            labelGagnantJ3.Visible = false;
            labelGagnantJ4.Visible = false;

            buttonArreter.Enabled = false;
            labelTourActuel.Text = $"Tour " + maPartie.tourActuel + "/3";
            labelTourNomJoueur.Text = $"C'est le tour de " + maPartie.joueurs[0].nomJoueur + " Joueur #" + maPartie.joueurs[0].numeroJoueur;
            affichagePointage();
        }

        private void buttonLancerDes_Click(object sender, EventArgs e)
        {
            int tourActuel = maPartie.tourActuel;
            string[] fichiers = { "Rouge_1.png", "Rouge_2.png", "Rouge_3.png", "Rouge_4.png", "Rouge_5.png", "Rouge_6.png" };

            SoundPlayer son1 = new SoundPlayer();
            son1.SoundLocation = chemin + "\\" + "sonRoulementDes.wav";
            son1.Play();

            pictureBoxDes1.Visible = true;
            pictureBoxDes2.Visible = true;
            pictureBoxDes3.Visible = true;

            jeu = new Thread(t =>
            {
                try
                {
                    while (jeu.IsAlive)
                    {
                        foreach (ImageJeu image in listImage)
                        {
                            pictureBoxDes1.ImageLocation =
                            fichiers[desAleatoire.Next(fichiers.Length)];

                            pictureBoxDes2.ImageLocation =
                            fichiers[desAleatoire.Next(fichiers.Length)];

                            pictureBoxDes3.ImageLocation =
                            fichiers[desAleatoire.Next(fichiers.Length)];

                            Thread.Sleep(50);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            })
            { IsBackground = true };
            jeu.Start();

            buttonArreter.Enabled = true;
            buttonLancerDes.Enabled = false;

            if (maPartie.tourActuel <= 3)
            {
                labelTourActuel.Text = "Tour " + maPartie.tourActuel + "/3";

                if (joueurActuel < maPartie.nbJoueurs)
                {
                    Joueur joueur = maPartie.joueurs[joueurActuel];

                    labelTourNomJoueur.Text = "C'est le tour de " + joueur.nomJoueur + " Joueur #" + joueur.numeroJoueur;
                    joueurActuel++;

                    if (joueurActuel == maPartie.nbJoueurs)
                    {
                        joueurActuel = 0;
                        maPartie.incrementerTour();
                    }
                }               
            }
        }

        private void buttonArreter_Click(object sender, EventArgs e)
        {
            jeu.Interrupt();
            int valeur1 = 0, valeur2 = 0, valeur3 = 0;
            int nbJoueurs = maPartie.nbJoueurs;

            buttonLancerDes.Enabled = true;
            buttonArreter.Enabled = false;

            foreach (ImageJeu image in listImage)
            {
                if (image.cheminImage == pictureBoxDes1.ImageLocation)
                {
                    valeur1 = image.pointage;
                }
                if (image.cheminImage == pictureBoxDes2.ImageLocation)
                {
                    valeur2 = image.pointage;
                }
                if (image.cheminImage == pictureBoxDes3.ImageLocation)
                {
                    valeur3 = image.pointage;
                }
            }

            if (labelTourNomJoueur.Text.Contains(maPartie.joueurs[0].numeroJoueur.ToString()))
            {
                maPartie.joueurs[0].pointage += valeur1 + valeur2 + valeur3;
                textBoxPointageJ1.Text = maPartie.joueurs[0].pointage.ToString();
                textBoxPointageJ1.Focus();
            }

            if (labelTourNomJoueur.Text.Contains(maPartie.joueurs[1].numeroJoueur.ToString()))
            {
                maPartie.joueurs[1].pointage += valeur1 + valeur2 + valeur3;
                textBoxPointageJ2.Text = maPartie.joueurs[1].pointage.ToString();
                textBoxPointageJ2.Focus();
            }

            // 2 représente l'indice du joueur 3
            if (2 < maPartie.nbJoueurs) 
            { 
                if (labelTourNomJoueur.Text.Contains(maPartie.joueurs[2].numeroJoueur.ToString())) 
                {
                    maPartie.joueurs[2].pointage += valeur1 + valeur2 + valeur3;
                    textBoxPointageJ3.Text = maPartie.joueurs[2].pointage.ToString();
                    textBoxPointageJ3.Focus();
                }         
            }

            // 3 représente l'indice du joueur 4
            if (3 < maPartie.nbJoueurs)
            {
                if (labelTourNomJoueur.Text.Contains(maPartie.joueurs[3].numeroJoueur.ToString()))
                {
                    maPartie.joueurs[3].pointage += valeur1 + valeur2 + valeur3;
                    textBoxPointageJ4.Text = maPartie.joueurs[3].pointage.ToString();
                    textBoxPointageJ4.Focus();
                }  
            }

            if (maPartie.tourActuel > 3)
            {
                buttonLancerDes.Enabled = false;
                buttonArreter.Enabled = false;
                affichageGagnant();
                MessageBox.Show("La partie est terminée. Relancez une nouvelle partie avec Ctrl + C.", "Fin de la partie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void affichageGagnant()
        {
            if (maPartie.nbJoueurs == 2)
            {
                labelGagnantJ1.Visible = (maPartie.joueurs[0].pointage > maPartie.joueurs[1].pointage);
                labelGagnantJ2.Visible = (maPartie.joueurs[1].pointage > maPartie.joueurs[0].pointage);
            }
            if (maPartie.nbJoueurs == 3)
            {
                labelGagnantJ1.Visible = (maPartie.joueurs[0].pointage > maPartie.joueurs[1].pointage && maPartie.joueurs[0].pointage > maPartie.joueurs[2].pointage);
                labelGagnantJ2.Visible = (maPartie.joueurs[1].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[1].pointage > maPartie.joueurs[2].pointage);
                labelGagnantJ3.Visible = (maPartie.joueurs[2].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[2].pointage > maPartie.joueurs[1].pointage);
            }

            if (maPartie.nbJoueurs == 4)
            {
                labelGagnantJ1.Visible = (maPartie.joueurs[0].pointage > maPartie.joueurs[1].pointage && maPartie.joueurs[0].pointage > maPartie.joueurs[2].pointage && 
                                          maPartie.joueurs[0].pointage > maPartie.joueurs[3].pointage);
                labelGagnantJ2.Visible = (maPartie.joueurs[1].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[1].pointage > maPartie.joueurs[2].pointage &&
                                          maPartie.joueurs[1].pointage > maPartie.joueurs[3].pointage);
                labelGagnantJ3.Visible = (maPartie.joueurs[2].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[2].pointage > maPartie.joueurs[1].pointage &&
                                          maPartie.joueurs[2].pointage > maPartie.joueurs[3].pointage);
                labelGagnantJ4.Visible = (maPartie.joueurs[3].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[3].pointage > maPartie.joueurs[1].pointage &&
                                          maPartie.joueurs[3].pointage > maPartie.joueurs[2].pointage);
            }

            SoundPlayer son2 = new SoundPlayer();
            son2.SoundLocation = Application.StartupPath + "\\" + "sonFinPartie.wav";
            son2.Play();
        }
       
        public void affichagePointage()
        {
            int nbJoueurs = maPartie.nbJoueurs;

            if (nbJoueurs >= 1)
            {
                textBoxPointageJ1.Text = maPartie.joueurs[0].pointage.ToString();
                labelPointageJ1.Visible = true;
                textBoxPointageJ1.Visible = true;
            }
            else
            {
                labelPointageJ1.Visible = false;
                textBoxPointageJ1.Visible = false;
            }

            if (nbJoueurs >= 2)
            {
                textBoxPointageJ2.Text = maPartie.joueurs[1].pointage.ToString();
                labelPointageJ2.Visible = true;
                textBoxPointageJ2.Visible = true;
            }
            else
            {
                labelPointageJ2.Visible = false;
                textBoxPointageJ2.Visible = false;
            }

            if (nbJoueurs >= 3)
            {
                textBoxPointageJ3.Text = maPartie.joueurs[2].pointage.ToString();
                labelPointageJ3.Visible = true;
                textBoxPointageJ3.Visible = true;
            }
            else
            {
                labelPointageJ3.Visible = false;
                textBoxPointageJ3.Visible = false;
            }

            if (nbJoueurs >= 4)
            {
                textBoxPointageJ4.Text = maPartie.joueurs[3].pointage.ToString();
                labelPointageJ4.Visible = true;
                textBoxPointageJ4.Visible = true;       
            }
            else
            {
                labelPointageJ4.Visible = false;
                textBoxPointageJ4.Visible = false;
            }
        }

        private void retourÀLaccueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouvellePartieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int nbJoueurs = maPartie.nbJoueurs;

            buttonLancerDes.Enabled = true;
            buttonArreter.Enabled = false;

            if (nbJoueurs >= 1) { 
                maPartie.joueurs[0].pointage = 0;
                textBoxPointageJ1.Text = "0";
            }
            if (nbJoueurs >= 2)
            {
                maPartie.joueurs[1].pointage = 0;
                textBoxPointageJ2.Text = "0";
            }
            if (nbJoueurs >= 3)
            {
                maPartie.joueurs[2].pointage = 0;
                textBoxPointageJ3.Text = "0";
            }
            if (nbJoueurs >= 4)
            {
                maPartie.joueurs[3].pointage = 0;
                textBoxPointageJ4.Text = "0";
            }

            joueurActuel = 0;
            labelTourNomJoueur.Text = "C'est le tour de " + maPartie.joueurs[0].nomJoueur + " Joueur #" + maPartie.joueurs[0].numeroJoueur;

            maPartie.tourActuel = 1;
            labelTourActuel.Text = "Tour " + maPartie.tourActuel.ToString() + "/3";

            labelGagnantJ1.Visible = false;
            labelGagnantJ2.Visible = false;
            labelGagnantJ3.Visible = false;
            labelGagnantJ4.Visible = false;

            pictureBoxDes1.Visible = false;
            pictureBoxDes2.Visible = false;
            pictureBoxDes3.Visible = false;
        }

        private void sauvegarderPointageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialogFichierPointage.InitialDirectory = Application.StartupPath + "\\";
            saveFileDialogFichierPointage.FileName = "fichierPointage.txt";

            if (saveFileDialogFichierPointage.ShowDialog() == DialogResult.OK)
            {
                StreamWriter ecrire = new StreamWriter(saveFileDialogFichierPointage.FileName, true);

                for (int i = 0; i < maPartie.nbJoueurs; i++)
                {
                    ecrire.WriteLine(maPartie.joueurs[i].nomJoueur + " - " + maPartie.joueurs[i].pointage);

                    if (maPartie.nbJoueurs == 2)
                    {
                        if (maPartie.joueurs[0].pointage > maPartie.joueurs[1].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[0].pointage;
                        }
                        if (maPartie.joueurs[1].pointage > maPartie.joueurs[0].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[1].pointage;
                        }
                    }

                    if (maPartie.nbJoueurs == 3)
                    {
                        if (maPartie.joueurs[0].pointage > maPartie.joueurs[1].pointage && maPartie.joueurs[0].pointage >
                        maPartie.joueurs[2].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[0].pointage;
                        }
                        if (maPartie.joueurs[1].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[1].pointage >
                            maPartie.joueurs[2].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[1].pointage;
                        }
                        if (maPartie.joueurs[2].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[2].pointage >
                            maPartie.joueurs[1].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[2].pointage;
                        }
                    }

                    if (maPartie.nbJoueurs == 4)
                    {
                        if (maPartie.joueurs[0].pointage > maPartie.joueurs[1].pointage && maPartie.joueurs[0].pointage >
                        maPartie.joueurs[2].pointage && maPartie.joueurs[0].pointage > maPartie.joueurs[3].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[0].pointage;
                        }
                        if (maPartie.joueurs[1].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[1].pointage >
                            maPartie.joueurs[2].pointage && maPartie.joueurs[1].pointage > maPartie.joueurs[3].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[1].pointage;
                        }
                        if (maPartie.joueurs[2].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[2].pointage >
                            maPartie.joueurs[1].pointage && maPartie.joueurs[2].pointage > maPartie.joueurs[3].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[2].pointage;
                        }
                        if (maPartie.joueurs[3].pointage > maPartie.joueurs[0].pointage && maPartie.joueurs[3].pointage >
                            maPartie.joueurs[1].pointage && maPartie.joueurs[3].pointage > maPartie.joueurs[2].pointage)
                        {
                            meilleursPointages = maPartie.joueurs[3].pointage;
                        }
                    }     
                }
                ecrire.Close();
            }
        }

        private void toolStripTextBoxNomJ1_TextChanged(object sender, EventArgs e)
        {
            maPartie.joueurs[0].nomJoueur = toolStripTextBoxNomJ1.Text;
            labelPointageJ1.Text = maPartie.joueurs[0].nomJoueur;
        }

        private void toolStripTextBoxNomJ2_TextChanged(object sender, EventArgs e)
        {
            maPartie.joueurs[1].nomJoueur = toolStripTextBoxNomJ2.Text;
            labelPointageJ2.Text = maPartie.joueurs[1].nomJoueur;
        }

        private void toolStripTextBoxNomJ3_TextChanged(object sender, EventArgs e)
        {
            maPartie.joueurs[2].nomJoueur = toolStripTextBoxNomJ3.Text;
            labelPointageJ3.Text = maPartie.joueurs[2].nomJoueur;
        }

        private void toolStripTextBoxNomJ4_TextChanged(object sender, EventArgs e)
        {  
            maPartie.joueurs[3].nomJoueur = toolStripTextBoxNomJ4.Text;
            labelPointageJ4.Text = maPartie.joueurs[3].nomJoueur;
        }
    }
}
