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
    public class Test_CreateOrigen
    {
        [TestMethod]
        public void TestCreateOrigen()
        {
            try
            {
                ModeloCodigoDeBarrasOrigen nuevoRegistro = new ModeloCodigoDeBarrasOrigen
                {
                    Radicado = 1234567890,
                    Id = 1,
                    Empleado = "Juan Perez Us1",
                    Identificacion = "9876543210",
                    TipoDocumental = "Informe",
                    CodigoDeBarrasRecepcion = "CBR1234567890",
                    CbDocumento = null,
                    CbExpediente = null,
                    CbCaja = null
                };
                
                CrudCodigoDeBarrasOrigen objCreate = new CrudCodigoDeBarrasOrigen();
                bool resultado = objCreate.CreateOrigen(nuevoRegistro);

                Assert.IsTrue(resultado, "[Test Create Origen] La creación del registro de código de barras origen falló.");

                Console.WriteLine("[Test Create Origen] La creación del registro de código de barras origen fue exitosa.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"[Test Create Origen] La prueba falló con una excepción: {ex.Message}");
            }
        }
    }
}
