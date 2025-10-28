using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaTesting.Testing_CapaNegocio_Origen
{
    [TestClass]
    public class GuardarListaOrigen
    {
        [TestMethod]
        public void TestCapaNegocioOrigenCrear()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail($"[TestCapaNegocioOrigenCrear] La prueba fallo con una excepción: {ex.Message}");
            }
        }
    }
}