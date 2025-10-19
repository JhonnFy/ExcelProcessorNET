using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class modeloCodigoDeBarras
    {
    
        public int IdIdentity { get; set;}
        public long Radicado { get; set;}
        public long Id { get; set;}
        public string Empleado { get; set;}
        public string Identificacion { get; set;}
        public string Tipo_Documental { get; set; }
        public string Codigo_De_Barras_Recepcion {get; set;}
        public string CB_Documento { get; set;}
        public string CB_Expediente { get; set;}
        public string CB_Caja { get; set;}

    }
}
