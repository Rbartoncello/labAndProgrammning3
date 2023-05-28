using Entidades;
using Entidades.Exeptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntidadesTests.Exeptions
{
    [TestClass()]
    public class CompetenciaNoDisponibleExceptionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void SeLanzaCompetenciaNoDisponibleExceptionAlCargarUnAutoF1EnCompetenciaMotoCrossTest()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(1, 1, Competencia<VehiculoDeCarrera>.ETipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1("a1", 1);
            bool foo = competencia + auto;

        }

        [TestMethod()]

        public void NoSeLanzaCompetenciaNoDisponibleExceptionAlCargarUnaMotoCrossEnCompetenciaMotoCrossTest()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(1, 1, Competencia<VehiculoDeCarrera>.ETipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross("m1", 1);
            Assert.ThrowsException<CompetenciaNoDisponibleException>(() => competencia + moto);
        }
    }
}