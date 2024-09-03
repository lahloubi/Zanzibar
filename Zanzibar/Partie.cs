using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zanzibar
{
    public class Partie
    {
        private int _nbJoueurs;
        private int _nbDes;
        private List<Joueur> _joueurs;
        private int _tourActuel;

        public int nbJoueurs
        { 
            get { return _nbJoueurs; }
            set { _nbJoueurs = value;}
        }

        public int nbDes
        {
            get { return _nbDes; }
            set { _nbDes = value; }
        }

        public List<Joueur> joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        public int tourActuel
        {
            get { return _tourActuel; }
            set { _tourActuel = value; }
        }

        public Partie() { }

        public Partie(int pNbJoueurs, int pNbDes, List<Joueur> pJoueurs, int pTourActuel)
        {
            this.nbJoueurs = pNbJoueurs;
            this.nbDes = pNbDes;
            this.joueurs = pJoueurs;
            this.tourActuel = pTourActuel;
        }

        public void incrementerTour()
        {
            tourActuel++;
        }
    }
}

