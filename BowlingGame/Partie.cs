using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Partie
    {
        public int nbQuilles { get; private set; } = 10;
        public int nbLancerRestant { get; private set; } = 2;
        public int Score { get; private set; } = 0;
        public int nbTours { get; private set; } = 0;


        public void TesterPartie()
        {
            
        }
    }
}
