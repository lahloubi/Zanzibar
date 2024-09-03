using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zanzibar
{
    public class ImageJeu
    {
        public int numero { get; private set; }
        public string face { get; private set; }
        public int pointage { get; private set; }
        public string cheminImage { get; private set; }

        public ImageJeu() { }

        public ImageJeu(int pNo, string pFace, int pPointage, string cheminImage)
        {
            this.numero = pNo;
            this.face = pFace;
            this.pointage = pPointage;
            this.cheminImage = cheminImage;
        }
    }
}
