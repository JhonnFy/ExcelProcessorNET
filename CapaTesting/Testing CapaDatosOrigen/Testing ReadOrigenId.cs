using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;

namespace CapaTesting.Testing_CapaDatos
{
    [TestClass]
    public class Testing_ReadOrigenId
    {
        [TestMethod]
        public void TestReadOrigenId()
        {
            try
            {
                CrudCodigoDeBarrasOrigen objReadOrigen = new CrudCodigoDeBarrasOrigen();
                var vobjReadOrigen = objReadOrigen.ReadOrigenId(120783560300);

                Assert.IsNotNull(vobjReadOrigen, "No se encontró registro con la CC proporcionada.");
                Assert.IsTrue(vobjReadOrigen.Count > 0, "La lista no debería estar vacía.");
                Assert.AreEqual("120783560300", vobjReadOrigen.First().Identificacion,
                "La CC del registro encontrado no coincide con la busqueda.");

                Console.WriteLine($"Registro encontrado: {vobjReadOrigen.First().Empleado}, CC: {vobjReadOrigen.First().Identificacion}");
            }
            catch (Exception ex)
            {
                Assert.Fail("[Testing ReadOrigenId]Se ha producido una excepción durante la prueba: " + ex.Message);
            }
        }
    }
}
