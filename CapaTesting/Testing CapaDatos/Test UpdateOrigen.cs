using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Empleado = "Juan Perez Us1",
                    Identificacion = "9876543210",
                    TipoDocumental = "Informe Actualizado",
                    CodigoDeBarrasRecepcion = "CBR1234567890",
                    CB_Documento = null
                };
            }
            catch (Exception ex)
            {
                Assert.Fail($"[Test Update Origen] La prueba falló con una excepción: {ex.Message}");
            }
        }

    }
}
