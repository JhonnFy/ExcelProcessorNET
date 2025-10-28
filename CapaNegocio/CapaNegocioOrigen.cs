using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CapaNegocioOrigen
    {
        //Instancia para acceder a la capa de datos
        private CrudCodigoDeBarrasOrigen datosOrigen;

        //Constructor
        public CapaNegocioOrigen()
        {
            datosOrigen = new CrudCodigoDeBarrasOrigen();
        }

        //Método para guardar todos los registros de origen
        public int GuardarListaOrigen(List<ModeloCodigoDeBarrasOrigen> listaExcel)
        {
            if (listaExcel == null || listaExcel.Count == 0)
                return 0; // No hay registros que guardar

            int totalGuardados = 0;

            try
            {

                foreach (var registroOrigen in listaExcel)
                {

                    bool exito = datosOrigen.CreateOrigen(registroOrigen);
                    if (exito)
                        totalGuardados++;

                }

                Console.WriteLine($"[CapaNegocioOrigen] Proceso completado. Total guardados: {totalGuardados} de {listaExcel.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CapaNegocioOrigen] Error al guardar la lista de origen: {ex.Message}");
                throw;
            }

            return totalGuardados;
        }
    }
}
