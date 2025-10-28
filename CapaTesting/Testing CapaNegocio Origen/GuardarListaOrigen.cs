using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using CapaNegocio;

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
                CapaNegocioOrigen objNegocioOrigen = new CapaNegocioOrigen();

                List<ModeloCodigoDeBarrasOrigen> listaModeloOrigen = new List<ModeloCodigoDeBarrasOrigen>
                {
                    new ModeloCodigoDeBarrasOrigen
                    {
                        Radicado = 11,
                        Id = 11,
                        Empleado = "Guardar Lista Origen 11",
                        Identificacion = "11",
                        TipoDocumental = "Tipo Test 11",
                        CodigoDeBarrasRecepcion = "CBR11",
                        CbDocumento = null,
                        CbExpediente = null,
                        CbCaja = null
                    },

                    new ModeloCodigoDeBarrasOrigen
                    {
                        Radicado = 12,
                        Id = 12,
                        Empleado = "Guardar Lista Origen 12",
                        Identificacion = "12",
                        TipoDocumental = "Tipo Test 12",
                        CodigoDeBarrasRecepcion = "CBR12",
                        CbDocumento = null,
                        CbExpediente = null,
                        CbCaja = null
                    }

                };


                bool resultado = objNegocioOrigen.GuardarListaOrigen(listaModeloOrigen) > 0;

                Assert.IsTrue(resultado, "[Test CapaNegocioOrigen] La creación del registro de código de barras origen falló.");

                Console.WriteLine("[Test CapaNegocioOrigen] La creación del registro de código de barras origen fue exitosa.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"[TestCapaNegocioOrigenCrear] La prueba fallo con una excepción: {ex.Message}");
            }
        }
    }
}