using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CrudCodigoDeBarrasOrigen
    {
        private Conexion conexion = new Conexion();
                
        public List<ModeloCodigoDeBarrasOrigen> LeerOrigen() { 
        
            var lista = new List<ModeloCodigoDeBarrasOrigen>();
            
            try
            {
                




            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer los orígenes de código de barras: " + ex.Message);
            }

            return lista;
        }

    }
}
