using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;


namespace CapaControlador
{
    public class CapaControladorOrigen
    {

        CapaNegocioOrigen objCapaNegocioOrigen;

        public CapaControladorOrigen()
        {
            objCapaNegocioOrigen = new CapaNegocioOrigen();
        }

        public int GuardarRegistrosOrigen(List<ModeloCodigoDeBarrasOrigen> listaExcel)
        {
            if (listaExcel is null || listaExcel.Count == 0)
            {
                Console.WriteLine("[CapaControladorOrigen] La lista de registros está vacía o es nula.");
                return 0;
            }

           
            try
            {
                int totalGuardados = objCapaNegocioOrigen.GuardarListaOrigen(listaExcel);

                Console.WriteLine($"[CapaControladorOrigen] Total de registros guardados: {totalGuardados}");
                return totalGuardados;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CapaControladorOrigen] Error al guardar los registros: {ex.Message}");
                throw;
            }
        }
    }
}
