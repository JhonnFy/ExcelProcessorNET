using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CrudCodigoDeBarrasOrigen
    {
        //DB
        private Conexion conexion = new Conexion();

        //READ
        public List<ModeloCodigoDeBarrasOrigen> LeerOrigen() { 
        
            var lista = new List<ModeloCodigoDeBarrasOrigen>();

            try
            {

            }catch (Exception ex)
            {
                throw new Exception("Error al leer los orígenes de código de barras: " + ex.Message);
            }

            return lista;
        }

    }
}
