using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace CapaDatos
{
    public class CrudCodigoDeBarrasOrigen
    {
        private Conexion conexion = new Conexion();
                
        public List<ModeloCodigoDeBarrasOrigen> ReadOrigen() { 
        
            var listaReadOrigen = new List<ModeloCodigoDeBarrasOrigen>();
            
            try
            {            
                using (var db = conexion.ObtenerConexion())
                {
                    db.Open();
                    string @read =
                        "SELECT " +
                        "IdIdentity, Radicado, Id, Empleado, Identificacion, Tipo_Documental, Codigo_De_Barras_Recepcion, " +
                        "CB_Documento, CB_Expediente, CB_Caja FROM CodigoDeBarrasOrigen";

                    using (SqlCommand readSql = new SqlCommand(read, db))
                    using (SqlDataReader runReadSQL = readSql.ExecuteReader())
                    {
                        while (runReadSQL.Read())
                        {
                            var modelo = new ModeloCodigoDeBarrasOrigen
                            {
                                IdIdentity = runReadSQL.GetInt32(0),
                                Radicado = runReadSQL.GetInt64(1),
                                Id = runReadSQL.GetInt64(2),
                                Empleado = runReadSQL.GetString(3),
                                Identificacion = runReadSQL.GetString(4),
                                TipoDocumental = runReadSQL.GetString(5),
                                CodigoDeBarrasRecepcion = runReadSQL.GetString(6),
                                CbDocumento = runReadSQL.IsDBNull(7) ? null : runReadSQL.GetString(7),
                                CbExpediente = runReadSQL.IsDBNull(8) ? null : runReadSQL.GetString(8),
                                CbCaja = runReadSQL.IsDBNull(9) ? null : runReadSQL.GetString(9)
                            };
                            listaReadOrigen.Add(modelo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("[ReadOrigen].[Error al leer los orígenes de código de barras] " + ex.Message);
            }

            return listaReadOrigen;
        }

        public List<ModeloCodigoDeBarrasOrigen> ReadOrigenId(long identificacion)
        {
              var listaReadOrigenId = new List<ModeloCodigoDeBarrasOrigen>();

            try
            {
                using (var db = conexion.ObtenerConexion())
                
                {
                    db.Open();
                    string @read = 
                        "SELECT " +
                        "IdIdentity, Radicado, Id, Empleado, Identificacion, Tipo_Documental, Codigo_De_Barras_Recepcion, " +
                        "CB_Documento, CB_Expediente, CB_Caja " +
                        "FROM CodigoDeBarrasOrigen " +
                        "WHERE Identificacion = @Identificacion";

                    using (SqlCommand readSql = new SqlCommand(read, db))
                    {

                        readSql.Parameters.AddWithValue("@Identificacion", identificacion); 

                        using (SqlDataReader runReasSql = readSql.ExecuteReader())
                        {
                                if (runReasSql.Read())
                                {
                                    var modelo = new ModeloCodigoDeBarrasOrigen
                                    {
                                        IdIdentity = runReasSql.GetInt32(0),
                                        Radicado = runReasSql.GetInt64(1),
                                        Id = runReasSql.GetInt64(2),
                                        Empleado = runReasSql.GetString(3),
                                        Identificacion = runReasSql.GetString(4),
                                        TipoDocumental = runReasSql.GetString(5),
                                        CodigoDeBarrasRecepcion = runReasSql.GetString(6),
                                        CbDocumento = runReasSql.IsDBNull(7) ? null : runReasSql.GetString(7),
                                        CbExpediente = runReasSql.IsDBNull(8) ? null : runReasSql.GetString(8),
                                        CbCaja = runReasSql.IsDBNull(9) ? null : runReasSql.GetString(9)
                                    };
                                    listaReadOrigenId.Add(modelo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("[ReadOrigenPorId].[Error al leer el código de barras por Id]" + ex.Message);
            }
            return listaReadOrigenId;
        }

        public bool CreateOrigen(ModeloCodigoDeBarrasOrigen nuevoRegistro)
        {
            try
            {
                using var db = conexion.ObtenerConexion();
                db.Open();

                string @create =  
                    "INSERT INTO CodigoDeBarrasOrigen " +
                    "(Radicado,Id,Empleado,Identificacion,Tipo_Documental,Codigo_De_Barras_Recepcion,CB_Documento,CB_Expediente,CB_Caja) " +
                    "VALUES " +
                    "(@Radicado,@Id,@Empleado,@Identificacion,@Tipo_Documental,@Codigo_De_Barras_Recepcion,@CB_Documento,@CB_Expediente,@CB_Caja)";

                using (SqlCommand createSql = new SqlCommand(@create, db))
                {
                    createSql.Parameters.AddWithValue("@Radicado", nuevoRegistro.Radicado);
                    createSql.Parameters.AddWithValue("@Id", nuevoRegistro.Id);
                    createSql.Parameters.AddWithValue("@Empleado", nuevoRegistro.Empleado);
                    createSql.Parameters.AddWithValue("@Identificacion", nuevoRegistro.Identificacion);
                    createSql.Parameters.AddWithValue("@Tipo_Documental", nuevoRegistro.TipoDocumental);
                    createSql.Parameters.AddWithValue("@Codigo_De_Barras_Recepcion", nuevoRegistro.CodigoDeBarrasRecepcion);

                    createSql.Parameters.AddWithValue("@CB_Documento", nuevoRegistro.CbDocumento ?? (object)DBNull.Value);
                    createSql.Parameters.AddWithValue("@CB_Expediente", nuevoRegistro.CbExpediente ?? (object)DBNull.Value);
                    createSql.Parameters.AddWithValue("@CB_Caja", nuevoRegistro.CbCaja ?? (object)DBNull.Value);

                    int filasAfectadas = createSql.ExecuteNonQuery();
                    return filasAfectadas > 0;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("[CreateOrigen].[Error al crear el código de barras origen] " + ex.Message);
            }
        }

    }
}
