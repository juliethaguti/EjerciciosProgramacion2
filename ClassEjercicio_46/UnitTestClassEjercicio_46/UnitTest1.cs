using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassEjercicio_30;
using ClassEjercicio_43;

namespace UnitTestClassEjercicio_46
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarInstanciaListaVehiculos()
        {
            Competencia c = new Competencia(10, 20, TipoCompetencia.MotoCross);

            Assert.IsNotNull(c.Competidores);
        }

        [TestMethod]
        public void ControlarExcepcionCargarAutoEnMotocrosss()
        {
            Competencia motocross = new Competencia(20, 30, TipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(8, "Williams", 50);
            try
            {
                bool retorno = motocross + auto;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CompetenciaNoDisponibleException));
            }
        }

        [TestMethod]
        public void ControlarExcepcionCargarMotoEnMotocross()
        {
            Competencia motocross = new Competencia(30, 15, TipoCompetencia.MotoCross);
            VehiculoDeCarrera moto = new Motocross(99, "Suzuki");

            try
            {
                bool retorno = motocross + moto;
            }
            catch(Exception e)
            {
                Assert.IsNotInstanceOfType(e, typeof(CompetenciaNoDisponibleException));
            }
        }

        [TestMethod]
        public void ComprobarVehiculoAgregado()
        {
            Competencia c = new Competencia(30, 15, TipoCompetencia.F1);
            VehiculoDeCarrera a = new AutoF1(10, "McClaren");

            if (c + a)
            {
                Assert.IsTrue(c == a);
            }
        }

        [TestMethod]
        public void ComprobarVehiculoQuitado()
        {
            Competencia c = new Competencia(30, 15, TipoCompetencia.F1);
            AutoF1 a = new AutoF1(8,"Renault");

            if(c - a)
            {
                Assert.IsTrue(c != a);
            }
        }

    }
}
