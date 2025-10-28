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
                        Radicado = 7,
                        Id = 7,
                        Empleado = "Modelo Codigo De Barras Origen 3",
                        Identificacion = "999999999",
                        TipoDocumental = "Tipo Test 9",
                        CodigoDeBarrasRecepcion = "CBR999999999",
                        CbDocumento = null,
                        CbExpediente = null,
                        CbCaja = null
                    },

                    new ModeloCodigoDeBarrasOrigen
                    {
                        Radicado = 8,
                        Id = 8,
                        Empleado = "Modelo Codigo De Barras Origen 4",
                        Identificacion = "101010101010",
                        TipoDocumental = "Tipo Test 10",
                        CodigoDeBarrasRecepcion = "CBR101010101010",
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