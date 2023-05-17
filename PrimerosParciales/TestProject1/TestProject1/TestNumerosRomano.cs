using Entidades;
using System.Text;

namespace TestProject1
{
    [TestClass]
    public class TestNumerosRomano
    {
        [TestMethod]
        public void AlRecibirUnNumeroUno_EnDeberial_ObtenerUnNumeroRomano()
        {
            int numero = 1;
            string esperado = "I";
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void AlRecibirUnNumeroDos_EnDeberial_ObtenerUnNumeroRomano()
        {
            int numero = 2;
            string esperado = "II";
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void AlRecibirUnNumeroI_EnDeberial_ObtenerUnNumeroRomano(int i)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('I', i);

            string resultado = Conversor.ConvertirANumeroRomano(i);

            Assert.AreEqual(sb.ToString(), resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AlRecibirUnNumeroInvalido_EnDeberial_ObtenerUnError()
        {
            string resultado = Conversor.ConvertirANumeroRomano(0);
        }
    }
}