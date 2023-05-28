using Entidades.Classes;
using Entidades.Exeptions;

namespace Tests.Classes
{
    [TestClass()]
    public class MiClaseTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MetodoEstaticoTest()
        {
            MiClase.MetodoEstatico();
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClaseTest()
        {
            MiClase clase = new MiClase();
        }
        [TestMethod()]
        [DataRow(1)]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClaseTestConParametros(int i)
        {
            MiClase clase = new MiClase(i);
        }
    }
}