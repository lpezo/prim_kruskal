using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ARM.Tests
{
    [TestClass]
    public class KruskalTestsFixture
    {
        [TestMethod]
        public void DeberiaRetornarListaVaciaSiElGrafoEstaVacio()
        {
            var g = new Grafo();
            var l = Kruskal.Ejecutar(g);
            Assert.IsNotNull(l);
            Assert.AreEqual(0, l.Count);
        }

        [TestMethod]
        public void DeberiaRetornarListaCon1NodoSiElGrafoTiene1Nodo()
        {
            var g = new Grafo();
            var n1 = new Nodo("N1");
            var n2 = new Nodo("N2");
            g.AgregarNodo(n1);
            g.AgregarNodo(n2);
            var e1 = new Enlace(2, n1, n2);
            g.AgregarEnlace(e1);
            
            var l = Kruskal.Ejecutar(g);
            Assert.IsNotNull(l);
            Assert.AreEqual(1, l.Count);
        }

        [TestMethod]
        public void DeberiaRetornarARMGrafo()
        {
            var g = new Grafo();
            var n1 = new Nodo("N1");
            var n2 = new Nodo("N2");
            var n3 = new Nodo("N3");
            var n4 = new Nodo("N4");
            var n5 = new Nodo("N5");
            var n6 = new Nodo("N6");

            g.AgregarNodo(n1);
            g.AgregarNodo(n2);
            g.AgregarNodo(n3);
            g.AgregarNodo(n4);
            g.AgregarNodo(n5);
            g.AgregarNodo(n6);

            var e1 = new Enlace(2, n1, n2);
            var e2 = new Enlace(7, n2, n3);
            var e3 = new Enlace(3, n1, n3);
            var e4 = new Enlace(20, n1, n6);
            var e5 = new Enlace(5, n3, n6);
            var e6 = new Enlace(9, n1, n5);
            var e7 = new Enlace(3, n5, n4);

            g.AgregarEnlace(e1);
            g.AgregarEnlace(e2);
            g.AgregarEnlace(e3);
            g.AgregarEnlace(e4);
            g.AgregarEnlace(e5);
            g.AgregarEnlace(e6);
            g.AgregarEnlace(e7);

            var l = Kruskal.Ejecutar(g);
            Assert.IsNotNull(l);
            Assert.AreEqual(5, l.Count);
            Assert.AreEqual(e1, l[0]);
            Assert.AreEqual(e3, l[1]);
            Assert.AreEqual(e7, l[2]);
            Assert.AreEqual(e5, l[3]);
            Assert.AreEqual(e6, l[4]);
        }
    }
}
