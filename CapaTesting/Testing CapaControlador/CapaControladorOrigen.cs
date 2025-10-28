using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaControlador;
using CapaDatos;

namespace CapaTesting.Testing_CapaControlador
{
    [TestClass]
    public class CapaControladorOrigen
    {
        [TestMethod]
        public void TestGuardarRegistrosOrigen()
        {
            try
            {
                var objControladorOrigen = new CapaControladorOrigen();

                

                var listaModeloOrigen = new List<ModeloCodigoDeBarrasOrigen>
                {
                    new ModeloCodigoDeBarrasOrigen
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
                    },
                    new ModeloCodigoDeBarrasOrigen
                    {
                        Radicado = 1234567891,
                        Id = 2,
                        Empleado = "Maria Gomez Us2",
                        Identificacion = "1234567890",
                        TipoDocumental = "Contrato",
                        CodigoDeBarrasRecepcion = "CBR1234567891",
                        CbDocumento = null,
                        CbExpediente = null,
                        CbCaja = null
                    }
                };
            }
            catch (Exception ex)
            {
                Assert.Fail($"[Test CapaControladorOrigen] La prueba falló con una excepción: {ex.Message}");
            }
        }
    }
}
