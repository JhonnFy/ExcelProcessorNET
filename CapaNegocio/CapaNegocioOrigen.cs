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

        private readonly CrudCodigoDeBarrasOrigen datosOrigen;


        public CapaNegocioOrigen()
        {
            datosOrigen = new CrudCodigoDeBarrasOrigen();
        }


        public int GuardarListaOrigen(List<ModeloCodigoDeBarrasOrigen> listaExcel)
        {
            if (listaExcel == null || listaExcel.Count == 0)
                return 0; 

            int totalGuardados = 0;

            foreach (var registroOrigen in listaExcel)
            {

                try
                {
                    bool exito = datosOrigen.CreateOrigen(registroOrigen);
                    if (exito)
                        totalGuardados++;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"ERROR [CapaNegocioOrigen].[GuardarListaOrigen]: {ex.Message}");
                    throw;
                }
            }

            //Console.WriteLine($"[CapaNegocioOrigen] Total de registros guardados correctamente: {totalGuardados} de {listaExcel.Count}");
            return totalGuardados;
        }
    }
}
