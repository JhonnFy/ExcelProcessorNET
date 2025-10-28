using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ModeloCodigoDeBarrasOrigen
    {
        public int IdIdentity { get; set; }
        public long Radicado { get; set; }
        public long Id { get; set; }
        public string Empleado { get; set; }
        public string Identificacion { get; set; }
        public string TipoDocumental { get; set; }
        public string CodigoDeBarrasRecepcion { get; set; }
        public string CbDocumento { get; set; }
        public string CbExpediente { get; set; }
        public string CbCaja { get; set; }

        public ModeloCodigoDeBarrasOrigen()
        {
            IdIdentity = 0;
            Radicado = 0;
            Id = 0;
            Empleado = string.Empty;
            Identificacion = string.Empty;
            TipoDocumental = string.Empty;
            CodigoDeBarrasRecepcion = string.Empty;
            CbDocumento = string.Empty;
            CbExpediente = string.Empty;
            CbCaja = string.Empty;
        }

    }
}
