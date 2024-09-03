using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zanzibar
{
    public class Joueur
    {
        private string _nomJoueur;
        private int _numeroJoueur;
        private int _pointage;

        public string nomJoueur 
        { 
            get { return _nomJoueur; }
            set { _nomJoueur = value;}
        }

        public int numeroJoueur
        {
            get { return _numeroJoueur; }
            set { _numeroJoueur = value;}       
        }

        public int pointage
        {
            get { return _pointage; }
            set { _pointage = value; }
        }

        public Joueur() { }

        public Joueur(string pNomJoueur, int pNumeroJoueur, int pPointage)
        {
            _nomJoueur = pNomJoueur;
            _numeroJoueur = pNumeroJoueur;
            _pointage = pPointage;
        }   
    }
}
