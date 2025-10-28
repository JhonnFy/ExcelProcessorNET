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
    public class Testing_ReadOrigen
    {
        [TestMethod]
        public void TestReadOrigen()
        {
            try
            {
                CrudCodigoDeBarrasOrigen objReadOrigen = new CrudCodigoDeBarrasOrigen();
                var vobjReadOrigen = objReadOrigen.ReadOrigen();

                Assert.IsNotNull(vobjReadOrigen, "El resultado no debe ser nulo.");
                Assert.IsInstanceOfType(vobjReadOrigen, typeof(List<ModeloCodigoDeBarrasOrigen>),
                    "El resultado debe ser una lista de ModeloCodigoDeBarrasOrigen.");
                Assert.IsTrue(vobjReadOrigen.Count > 0, "La lista debe contener al menos un registro.");


                Console.WriteLine($"Cantidad de registros devueltos: {vobjReadOrigen.Count}");

            }
            catch (Exception ex)
            {
                Assert.Fail($"La prueba falló con una excepción: {ex.Message}");
            }
        }
    }
}
