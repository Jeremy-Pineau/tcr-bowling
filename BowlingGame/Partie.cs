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
        public int Score { get; set; }
        public int nbTours { get; set; }


        public int Lancer(int ajoutScore)
        {
            return Score = ajoutScore;
        }
    }
}
