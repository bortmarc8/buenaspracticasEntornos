using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testunitario
{
    [TestClass]
    public class ClaseEstaticaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string retornar = AcmeApp.ClaseEstatica.RetornarString();
            Assert.AreEqual(retornar, "Hola, esto es un string");

        }
    }
}
