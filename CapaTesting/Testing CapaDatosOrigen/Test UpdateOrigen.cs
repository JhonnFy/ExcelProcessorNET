using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaTesting.Testing_CapaDatos
{
    [TestClass]
    public class Test_UpdateOrigen
    {
        [TestMethod]
        public void TestUpdateOrigen()
        {
            try
            {
                ModeloCodigoDeBarrasOrigen objUpdateOrigen = new ModeloCodigoDeBarrasOrigen
                {
                    Radicado = 1234567890,
                    Id = 1,
                    Empleado = "Juan Perez Modificado Test",
                    Identificacion = "120783560406",
                    TipoDocumental = "Informe Actualizado",
                    CodigoDeBarrasRecepcion = "CBR1234567890",
                    CbDocumento = null,
                    CbExpediente = null,
                    CbCaja = null
                };

                CrudCodigoDeBarrasOrigen objUpdate = new CrudCodigoDeBarrasOrigen();
                bool resultado = objUpdate.UpdateOrigen(objUpdateOrigen);

                Assert.IsTrue(resultado, "[Test Update Origen] La actualización del registro falló.");
                Console.WriteLine("[Test Update Origen] La actualización del registro fue exitosa");
            }
            catch (Exception ex)
            {
                Assert.Fail($"[Test Update Origen] La prueba falló con una excepción: {ex.Message}");
            }
        }

    }
}
