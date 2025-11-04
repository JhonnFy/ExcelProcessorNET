using CapaDatos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CapaNegocioOrigen
    {

        private readonly CrudCodigoDeBarrasOrigen datosOrigen;


        public CapaNegocioOrigen()
        {
            datosOrigen = new CrudCodigoDeBarrasOrigen();
        }

        public bool EliminarPorId(long id)
        {
            try
            {
                Debug.WriteLine($"[****].[OK].[CapaNegocioOrigen].[EliminarPorId].[Iniciado Id={id}]");

                if (id <= 0)
                    throw new ArgumentException("El Id Debe Ser Mayor A Cero");

                bool resultado = datosOrigen.DeleteOrigenPorId((int)id);
                Debug.WriteLine($"[****].[OK].[CapaNegocioOrigen].[EliminarPorId].[Resultado={resultado}]");

                return resultado;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("[****].[ERROR].[CapaNegocioOrigen].[EliminarPorId] " + ex.Message);
                throw new Exception("ERROR [Capa NegocioOrigen].[EliminarPorId] " + ex.Message, ex);
            }
        }

        public void LimpiarCodigoDeBarrasOrigen()
        {
            var datos = new CrudCodigoDeBarrasOrigen();
            datos.LimpiarCodigoDeBarrasOrigen();

            Debug.WriteLine("[****].[OK].[Capa CrudCapaNegocioOrigen].[LimpiarCodigoDeBarrasOrigen]");
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
                    Debug.WriteLine($"ERROR [CapaNegocioOrigen].[GuardarListaOrigen]: {ex.Message}");
                    throw;
                }
            }
            Debug.WriteLine($"[CapaNegocioOrigen] Total de registros guardados correctamente: {totalGuardados} de {listaExcel.Count}");
            return totalGuardados;
        }
    }
}
