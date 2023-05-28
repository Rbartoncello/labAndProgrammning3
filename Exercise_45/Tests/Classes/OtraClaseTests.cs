using Entidades.Classes;
using Entidades.Exeptions;

namespace Tests.Classes
{
    [TestClass()]
    public class OtraClaseTests
    {
        [TestMethod()]
        [ExpectedException(typeof(MiExcepcion))]
        public void MetodoInstanciaTest()
        {
            OtraClase clase = new OtraClase();
            clase.MetodoInstancia();
        }
    }
}