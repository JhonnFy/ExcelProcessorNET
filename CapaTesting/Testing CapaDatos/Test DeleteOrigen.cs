using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaTesting.Testing_CapaDatos
{
    [TestClass]
    public class Test_DeleteOrigen()
    {

        [TestMethod]
        public void TestDeleteOrigen()
        {
            try
            {
                ModeloCodigoDeBarrasOrigen borrarRegistro = new ModeloCodigoDeBarrasOrigen
                {
                    Identificacion = "9876543210"
                };

                CrudCodigoDeBarrasOrigen objDelete = new CrudCodigoDeBarrasOrigen();
                bool resultado = objDelete.DeleteOrigen(borrarRegistro);

                Assert.IsTrue(resultado, "[Test Delete Origen] No se eliminó ningún registro.");
                Console.WriteLine("[Test Delete Origen] El registro fue eliminado correctamente.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"[Test Delete Origen] La prueba falló con una excepción: {ex.Message}");
            }
        }
    }
}
