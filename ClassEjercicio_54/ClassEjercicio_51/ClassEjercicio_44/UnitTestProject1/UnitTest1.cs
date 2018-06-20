using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarListaLlamadasIstanciada()
        {
            Centralita c = new Centralita("CentralTest");
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        public void ControlarCargaLlamadaLocal()
        {
            Centralita c = new Centralita("CentralTest");
            Llamada l1 = new Local("Origen", 45, "Destino", 1);
            Llamada l2 = new Local("Origen", 72, "Destino", 2);

            try
            {
                c += l1;
                c += l2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void ControlarLlamadaProvincial()
        {
            Centralita c = new Centralita("Centralita Test");
            Llamada l1 = new Provincial("Origen", Franja.Franja_2, 45, "Destino");
            Llamada l2 = new Provincial("Origen", Franja.Franja_3, 12, "Destino");

            try
            {
                c += l1;
                c += l2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void CoontrolarLlamadas()
        {
            Llamada l1 = new Local("Origen", 12, "Destino", 1);
            Llamada l2 = new Local("Origen", 13, "Destino", 2);
            Llamada l3 = new Provincial("Origen", Franja.Franja_3, 13, "Destino");
            Llamada l4 = new Provincial("Origen", Franja.Franja_1,12, "Destino");

            Assert.IsTrue(l1 == l2);
            Assert.IsTrue(l3 == l4);
            Assert.IsFalse(l1 == l3);
            Assert.IsFalse(l1 == l4);
            Assert.IsFalse(l2 == l3);
            Assert.IsFalse(l2 == l4);

        }
    }
}
