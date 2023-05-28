using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntidadesTests
{
    [TestClass()]
    public class CompetenciaTests
    {
        [TestMethod()]
        public void CompetenciaTest()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(4, 1, Competencia<VehiculoDeCarrera>.ETipoCompetencia.F1);
                Assert.IsInstanceOfType(competencia.Competidores,typeof(List<VehiculoDeCarrera>));
        }
        [TestMethod()]
        public void SeAgregaVehiculoACompetenciaTest()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(4, 1, Competencia<VehiculoDeCarrera>.ETipoCompetencia.F1);
            AutoF1 auto = new AutoF1("a1", 1);
            Assert.AreEqual(true, (competencia + auto && competencia == auto));
        }

        [TestMethod()]
        public void SeEliminaVehiculoACompetenciaTest()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(4, 1, Competencia<VehiculoDeCarrera>.ETipoCompetencia.F1);
            AutoF1 auto = new AutoF1("a1", 1);
            competencia.Competidores.Add(auto);
            Assert.AreEqual(true, (competencia - auto && competencia != auto));
        }
    }
}