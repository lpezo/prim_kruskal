using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ARM.Tests
{
    [TestClass]
    public class NodoTestsFixture
    {
        [TestMethod]
        public void DeberiaCrearNodo()
        {
            Nodo n = new Nodo();
            Assert.IsNotNull(n);
        }

        [TestMethod]
        public void DeberiaCrearNodoConNombre()
        {
            string nombre = "nodo1";
            int x = 55;
            int y = 33; 
            Nodo n = new Nodo(nombre);
            Assert.AreEqual(nombre, n.nombre);
        }
        [TestMethod]
        public void DeberiaModificarNombre()
        {
            string nombre = "nodo1";
            int x = 55;
            int y = 33;
            Nodo n = new Nodo(nombre);
            n.nombre = "pepe";
            Assert.AreEqual(n.nombre, "pepe");
        }
    }
}
