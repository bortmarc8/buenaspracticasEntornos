using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testunitario
{
    [TestClass]
    public class Clase1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            AcmeApp.Clase1 clase_ctor_vacio = new AcmeApp.Clase1();
            Assert.AreEqual(clase_ctor_vacio.getFrase(), "Frase por defecto");

            AcmeApp.Clase1 clase_ctor_lleno = new AcmeApp.Clase1("Hola, he iniciado la clase");
            Assert.AreEqual(clase_ctor_lleno.getFrase(), "Hola, he iniciado la clase");

            clase_ctor_lleno.setFrase("Frase cambiada");
            Assert.AreEqual(clase_ctor_lleno.getFrase(), "Frase cambiada");
        }
    }
}
