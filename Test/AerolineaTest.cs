using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mundo;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class AerolineaTest
    {
        private Aerolinea aerolinea;
        private List<Ciudad> ciudadesTest;
        private List<Viajero> viajerosTest;
        private List<Ciudad> solucionesTest;
        private const String RUTA_TEST = "prueba de ciudades.txt";
        private const String RUTA_VIAJERO = "prueba de viajeros.txt";
        private const String RUTA_SOLUCION = "prueba solucion.txt";

        private void setupEscenario1()
        {
            aerolinea = new Aerolinea();
            ciudadesTest = new List<Ciudad>();
            Ciudad c1 = new Ciudad("andorra la vella", 42.5, 1.5166667, 20430);
            Ciudad c2 = new Ciudad("canillo", 42.5666667, 1.6, 3292);
            Ciudad c3 = new Ciudad("ciras", 35.416737, 65.982341, 12778);
            Ciudad c4 = new Ciudad("qunduz", 36.728955, 68.857001, 161943);
            Ciudad c5 = new Ciudad("swetes", 17.05, -61.8, 727);
            Ciudad c6 = new Ciudad("kerrabe", 41.2155556, 19.9713889, 1177);
            ciudadesTest.Add(c1);
            ciudadesTest.Add(c2);
            ciudadesTest.Add(c3);
            ciudadesTest.Add(c4);
            ciudadesTest.Add(c5);
            ciudadesTest.Add(c6);


        }
        private void escenarioCiudades()
        {
            aerolinea = new Aerolinea();
            aerolinea.cargarCiudades(RUTA_TEST);

        }
        private void escenarioViajeros()
        {
            aerolinea = new Aerolinea();
            aerolinea.cargarCiudades(RUTA_TEST);
            aerolinea.cargarViajeros(RUTA_VIAJERO, 0);
        }
        private void setupEscenario2()
        {
            aerolinea = new Aerolinea();
            aerolinea.cargarCiudades(RUTA_TEST);
            viajerosTest = new List<Viajero>();
            Viajero v1 = new Viajero("1", "Aaron Aaberg");
            Viajero v2 = new Viajero("2", "Adelaide Aaberg");
            Viajero v3 = new Viajero("7", "Alia Aaberg");
            Viajero v4 = new Viajero("1220991", "Wallace Zwilling");
            Viajero v5 = new Viajero("1220999", "Zoila Zwilling");
            viajerosTest.Add(v1);
            viajerosTest.Add(v2);
            viajerosTest.Add(v3);
            viajerosTest.Add(v4);
            viajerosTest.Add(v5);

        }
        private void escenarioSolucionKruskal1()
        {
            aerolinea = new Aerolinea();
            aerolinea.cargarCiudades(RUTA_TEST);
            aerolinea.cargarViajeros(RUTA_SOLUCION, 0);
            solucionesTest = new List<Ciudad>();
            Ciudad c1 = new Ciudad("andorra la vella", 42.5, 1.5166667, 20430);
            Ciudad c2 = new Ciudad("canillo", 42.5666667, 1.6, 3292);
            solucionesTest.Add(c1);
            solucionesTest.Add(c2);
            solucionesTest.Add(c1);


        }

        private void escenarioSolucionKruskal2()
        {
            aerolinea = new Aerolinea();
            aerolinea.cargarCiudades(RUTA_TEST);
            aerolinea.cargarViajeros(RUTA_SOLUCION, 0);
            solucionesTest = new List<Ciudad>();
            Ciudad c1 = new Ciudad("andorra la vella", 42.5, 1.5166667, 20430);
            Ciudad c2 = new Ciudad("canillo", 42.5666667, 1.6, 3292);
            Ciudad c3 = new Ciudad("sharan", 33.146667, 68.791667, 7368);
            Ciudad c4 = new Ciudad("uruzgan", 32.927751, 66.632534, 13400);
            Ciudad c5 = new Ciudad("all saints", 17.05, -61.8, 2526);
            solucionesTest.Add(c1);
            solucionesTest.Add(c2);
            solucionesTest.Add(c4);
            solucionesTest.Add(c3);
            solucionesTest.Add(c5);
            solucionesTest.Add(c1);

        }
        private void escenarioSolucionFuerzaBruta()
        {
            aerolinea = new Aerolinea();
            aerolinea.cargarCiudades(RUTA_TEST);
            aerolinea.cargarViajeros(RUTA_SOLUCION, 0);
            solucionesTest = new List<Ciudad>();
            Ciudad c1 = new Ciudad("andorra la vella", 42.5, 1.5166667, 20430);
            Ciudad c2 = new Ciudad("canillo", 42.5666667, 1.6, 3292);
            Ciudad c3 = new Ciudad("sharan", 33.146667, 68.791667, 7368);
            Ciudad c4 = new Ciudad("uruzgan", 32.927751, 66.632534, 13400);
            Ciudad c5 = new Ciudad("all saints", 17.05, -61.8, 2526);
            solucionesTest.Add(c1);
            solucionesTest.Add(c2);
            solucionesTest.Add(c4);
            solucionesTest.Add(c3);
            solucionesTest.Add(c5);
            solucionesTest.Add(c1);

        }
        private void escenarioDistanciaCiudades()
        {
            aerolinea = new Aerolinea();
            ciudadesTest = new List<Ciudad>();
            Ciudad c1 = new Ciudad("andorra la vella", 42.5, 1.5166667, 20430);
            Ciudad c2 = new Ciudad("canillo", 42.5666667, 1.6, 3292);
            Ciudad c3 = new Ciudad("sharan", 33.146667, 68.791667, 7368);
            Ciudad c4 = new Ciudad("uruzgan", 32.927751, 66.632534, 13400);
            Ciudad c5 = new Ciudad("all saints", 17.05, -61.8, 2526);
            ciudadesTest.Add(c1);
            ciudadesTest.Add(c2);
            ciudadesTest.Add(c3);
            ciudadesTest.Add(c4);
            ciudadesTest.Add(c5);

        }

        private void escenarioSolucionInsercion()
        {
            aerolinea = new Aerolinea();
            aerolinea.cargarCiudades(RUTA_TEST);
            aerolinea.cargarViajeros(RUTA_SOLUCION, 0);
            solucionesTest = new List<Ciudad>();
            Ciudad c1 = new Ciudad("andorra la vella", 42.5, 1.5166667, 20430);
            Ciudad c2 = new Ciudad("canillo", 42.5666667, 1.6, 3292);
            Ciudad c3 = new Ciudad("sharan", 33.146667, 68.791667, 7368);
            Ciudad c4 = new Ciudad("uruzgan", 32.927751, 66.632534, 13400);
            Ciudad c5 = new Ciudad("all saints", 17.05, -61.8, 2526);
            solucionesTest.Add(c1);
            solucionesTest.Add(c2);
            solucionesTest.Add(c4);
            solucionesTest.Add(c3);
            solucionesTest.Add(c5);
            solucionesTest.Add(c1);

        }
        [TestMethod]

        public void testCalcularDistancia()
        {
            escenarioDistanciaCiudades();
            Assert.AreEqual(ciudadesTest[0].calcularDistancia(ciudadesTest[1]),10);
            Assert.AreEqual(ciudadesTest[0].calcularDistancia(ciudadesTest[2]), 5844);
            Assert.AreEqual(ciudadesTest[0].calcularDistancia(ciudadesTest[3]), 5684);
            Assert.AreEqual(ciudadesTest[2].calcularDistancia(ciudadesTest[3]), 202);
        }

        [TestMethod]
        public void TestCargarCiudades()
        {
            setupEscenario1();
            aerolinea.cargarCiudades(RUTA_TEST);
            List<Ciudad> listaCiudades = darCiudades();
            Assert.AreEqual(ciudadesTest[0].Nombre, listaCiudades[0].Nombre);
            Assert.AreEqual(ciudadesTest[1].Latitud, listaCiudades[1].Latitud);
            Assert.AreEqual(ciudadesTest[2].Poblacion, listaCiudades[22].Poblacion);
            Assert.AreEqual(ciudadesTest[3].Longitud, listaCiudades[50].Longitud);
            Assert.AreEqual(ciudadesTest[4].Nombre, listaCiudades[73].Nombre);
            Assert.AreEqual(ciudadesTest[5].Poblacion, listaCiudades[97].Poblacion);

        }
        [TestMethod]
        public void testBuscarCiudades()
        {
            escenarioCiudades();
            Assert.AreEqual(aerolinea.buscarCiudad("the valley").Poblacion, 1379);
            Assert.AreEqual(null, aerolinea.buscarCiudad("ciudad dojo"));
            Assert.AreEqual("kerrabe", aerolinea.buscarCiudad("kerrabe").Nombre);
            Assert.AreEqual(41.3230556, aerolinea.buscarCiudad("durres").Latitud);
        }
        [TestMethod]
        public void testBuscarViajero()
        {
            escenarioViajeros();
            List<Viajero> viaj = aerolinea.Viajeros;
            Assert.AreEqual("Alda Aaberg", aerolinea.buscarViajero("5").Nombre);
            Assert.AreEqual("1220999", aerolinea.buscarViajero("1220999").Codigo);
            Assert.AreEqual(null, aerolinea.buscarViajero("000000"));

        }
        [TestMethod]
        public void testCargarViajero()
        {
            setupEscenario2();
            aerolinea.cargarViajeros(RUTA_VIAJERO, 0);
            List<Viajero> viajerosListos = aerolinea.Viajeros;
            Assert.AreEqual(viajerosTest[0].Nombre, viajerosListos[0].Nombre);
            Assert.AreEqual(viajerosTest[1].Codigo, viajerosListos[1].Codigo);
            Assert.AreEqual(viajerosTest[2].Nombre, viajerosListos[6].Nombre);
            Assert.AreEqual(viajerosTest[3].Codigo, viajerosListos[19].Codigo);
            Assert.AreEqual(viajerosTest[4].Nombre, viajerosListos[27].Nombre);
        }
        [TestMethod]
        public void testKruscal()
        {
            escenarioSolucionKruskal1();
            List<Ciudad> solucion = aerolinea.Viajeros[0].generarSolucionKruskal();
            Assert.IsTrue(ciudadesCorrectas(solucionesTest, solucion));
        }

        [TestMethod]
        public void testInsercion()
        {
            escenarioSolucionInsercion();
            List<Ciudad> solucion = aerolinea.Viajeros[1].generarSolucionInsercion();
            Assert.IsTrue(ciudadesCorrectas(solucionesTest, solucion));
        }



        [TestMethod]
        public void testKruscal2()
        {
            escenarioSolucionKruskal2();
            List<Ciudad> solucion = aerolinea.Viajeros[1].generarSolucionKruskal();
            Assert.IsTrue(ciudadesCorrectas(solucionesTest, solucion));
        }
        private Boolean ciudadesCorrectas(List<Ciudad> lista1, List<Ciudad> lista2)
        {
            Boolean correctas = true;
            for (int i = 0; i < lista1.Count; i++)
            {
                if (!lista1[i].Nombre.Equals(lista2[i].Nombre))
                {
                    correctas = false;
                }
            }

            return correctas;
        }
        [TestMethod]
        public void testFuerzaBruta()
        {
            escenarioSolucionFuerzaBruta();
            List<Ciudad> solucion = aerolinea.Viajeros[1].generarSolucionFuerzaBruta();
            Assert.IsTrue(ciudadesCorrectas(solucionesTest, solucion));
        }
        private List<Ciudad> darCiudades()
        {
            Dictionary<String, Ciudad> ciudades = aerolinea.Ciudades;
            List<Ciudad> listaCiudades = new List<Ciudad>();
            foreach (Ciudad c in ciudades.Values)
            {
                listaCiudades.Add(c);
            }
            return listaCiudades;
        }
    }
}
