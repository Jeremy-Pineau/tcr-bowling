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
            Assert.AreEqual(0, partie.nbTours);
        }

        [TestMethod]
        public void Lancer_Faisant_Tomber_5_quilles_test()
        {
            var partie = new Partie();
            partie.Lancer(5);

            Assert.AreEqual(5, partie.Score);
        }
    }
}