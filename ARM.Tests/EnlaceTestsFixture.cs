using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ARM.Tests
{
    [TestClass]
    public class EnlaceTestsFixture
    {
        [TestMethod]
        public void DeberiaCrearEnlace()
        {
            Enlace e = new Enlace();
            Assert.IsNotNull(e);
        }
        [TestMethod]
        public void DeberiaCrearEnlaceConNodosYPeso()
        {
            Nodo NodoA = new Nodo();
            Nodo NodoB = new Nodo();
            int peso = 33;

            Enlace e = new Enlace(peso, NodoA, NodoB);
            Assert.AreEqual(NodoA, e.NodoA);
            Assert.AreEqual(NodoB, e.NodoB);
            Assert.AreEqual(peso, e.Peso);
        }
        [TestMethod]
        public void DeberiaModificarNodoA()
        {
            Nodo NodoA = new Nodo();
            Nodo NodoB = new Nodo();
            Nodo NodoC = new Nodo();
            
            int peso = 33;

            Enlace e = new Enlace(peso, NodoA, NodoB);
            e.NodoA = NodoC;
            Assert.AreEqual(NodoC, e.NodoA);
        }
      
        [TestMethod]
        public void DeberiaModificarNodoB()
        {
            Nodo NodoA = new Nodo();
            Nodo NodoB = new Nodo();
            Nodo NodoC = new Nodo();

            int peso = 33;

            Enlace e = new Enlace(peso, NodoA, NodoB);
            e.NodoB = NodoC;
            Assert.AreEqual(NodoC, e.NodoB);
        }
        [TestMethod]
        public void DeberiaModificarPeso()
        {
            Nodo NodoA = new Nodo();
            Nodo NodoB = new Nodo();

            int peso = 33;
            int peso2 = 23;

            Enlace e = new Enlace(peso, NodoA, NodoB);
            e.Peso = peso2;
            Assert.AreEqual(peso2, e.Peso);
        }

        [TestMethod]
        public void DeberiaDevolverNodoNoVisitado()
        {
            Nodo NodoA = new Nodo();
            Nodo NodoB = new Nodo();
            NodoA.visitado = true;
            Enlace e = new Enlace(33, NodoA, NodoB);
            var NodoC = e.GetNodoNoVisitado();
            Assert.AreEqual(NodoC, NodoB);
        }

        [TestMethod]
        public void DeberiaDevolverTruePorqueLos2NodosFueronVisitados()
        {
            Nodo NodoA = new Nodo();
            Nodo NodoB = new Nodo();
            NodoA.visitado = true;
            NodoB.visitado = true;
            Enlace e = new Enlace(33, NodoA, NodoB);
            Assert.IsTrue(e.NodosVisitados());
        }

        [TestMethod]
        public void DeberiaDevolverFalsePorqueUnNodoNoFueroVisitado()
        {
            Nodo NodoA = new Nodo();
            Nodo NodoB = new Nodo();
            NodoA.visitado = true;
            NodoB.visitado = false;
            Enlace e = new Enlace(33, NodoA, NodoB);
            Assert.IsFalse(e.NodosVisitados());
        }

    }
}
