using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CapaDatos;


namespace CapaTesting
{

    [TestFixture]
    public class TestingCapaDatos
    {
        [Test]
        public void TestReadOrigen()
        {
            var @read = new CrudCodigoDeBarrasOrigen();
            var runread = read.ReadOrigen();

            Assert.Multiple(() =>
            {
                Assert.That(runread, Is.Not.Null, "La lista no debe ser nula.");
                Assert.That(runread, Is.InstanceOf<List<ModeloCodigoDeBarrasOrigen>>(),
                    "El tipo devuelto debe ser una lista de ModeloCodigoDeBarrasOrigen.");
                Assert.That(runread.Count, Is.GreaterThanOrEqualTo(0),
                    "La cantidad de registros no debe ser negativa.");

                Console.WriteLine($"Número de elementos en la lista: {runread.Count}");
            });

        }
    }
}
