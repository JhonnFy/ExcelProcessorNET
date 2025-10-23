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

                };
            }
            catch (Exception ex)
            {
                Assert.Fail($"[Test Update Origen] La prueba falló con una excepción: {ex.Message}");
            }
        }

    }
}
