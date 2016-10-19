using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IgraVjesala
{
    [TestClass]
    public class TestSkriveneRijeci
    {
        [TestMethod]
        public void ImasLiSlovoVračaTrueZaSlovoKojeJeURiječi()
        {
            SkrivenaRijec rijec = new Vjesala.SkrivenaRijec("mama");
            Assert.IsTrue(rijec.ImasLiSlovo('a'));
        }

        [TestMethod]
        public void ImasLiSlovoVračaTrueZaSlovoKojeJeURiječi()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsTrue(rijec.ImasLiSlovo('t'));
        }


        public void ImasLiSlovoVračaTrueZaSlovoKojeJeURiječi()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.AreEqual("____", rijec.Prikaz());
        }
    }
}
