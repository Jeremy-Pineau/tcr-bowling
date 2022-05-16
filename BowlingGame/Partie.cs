using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Partie
    {
        public int nbQuilles { get; set; } = 10;
        public int nbLancerRestant { get; set; } = 2;
        public int Score { get; private set; }
        public int nbTours { get; set; } = 10;

        public Joueurs Joueur { get; set; }

        public void Lancer(int ajoutScore)
        {
           Score = ajoutScore;
           nbLancerRestant--;
        }

        public void FinTour()
        {
            nbTours--;
        }
    }
}
