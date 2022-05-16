using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreationPartieTest()
        {
            var partie = new Partie();

            Assert.AreEqual(10, partie.nbQuilles);
            Assert.AreEqual(2, partie.nbLancerRestant);
            Assert.AreEqual(0, partie.Score);
            Assert.AreEqual(10, partie.nbTours);
        }

        [TestMethod]
        public void Lancer_Faisant_Tomber_3_quilles_test()
        {
            var partie = new Partie();
            partie.Lancer(3);

            Assert.AreEqual(3, partie.Score);
        }

        [TestMethod]
        public void Debuter_une_partie()
        {
            var partie = new Partie();
            var joueur = new Joueurs();
            partie.Joueur = joueur;

            Assert.AreNotEqual(null, partie.Joueur);
        }

        [TestMethod]
        public void Finir_Tour()
        {
            var partie = new Partie();
            partie.FinTour();

            Assert.AreEqual(9, partie.nbTours);
        }
    }
}