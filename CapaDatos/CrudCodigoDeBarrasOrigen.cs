using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CrudCodigoDeBarrasOrigen
    {
        private Conexion conexion = new Conexion();
                
        public List<ModeloCodigoDeBarrasOrigen> ReadOrigen() 
        { 
        
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
                Debug.WriteLine("[****].[ERROR].[Capa CrudCodigoDeBarrasOrigen].[ReadOrigen]");
                throw new Exception("ERROR [Capa CrudCodigoDeBarrasOrigen].[ReadOrigen] " + ex.Message);
            }

            return listaReadOrigen;
        }

        public void LimpiarCodigoDeBarrasOrigen()
        {
            using (var db = conexion.ObtenerConexion())
                try
            {
                db.Open();
                    string @query =
                        "DELETE FROM CodigoDeBarrasOrigen; " +
                        "DBCC CHECKIDENT ('CodigoDeBarrasOrigen', RESEED, 0);";

                    using (SqlCommand sqlCommand = new SqlCommand(@query, db))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    Debug.WriteLine("[****].[OK].[Capa CrudCodigoDeBarrasOrigen].[LimpiarCodigoDeBarrasOrigen]");
                }
            catch (Exception ex)
            {
                Debug.WriteLine("[****].[ERROR].[Capa CrudCodigoDeBarrasOrigen].[LimpiarCodigoDeBarrasOrigen]");
                throw new Exception("ERROR [Capa CrudCodigoDeBarrasOrigen].[LimpiarCodigoDeBarrasOrigen] " + ex.Message);
            }
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
                Debug.WriteLine("[****].[ERROR].[Capa CrudCodigoDeBarrasOrigen].[ReadOrigen]");
                throw new Exception("ERROR [Capa CrudCodigoDeBarrasOrigen].[ReadOrigenId]" + ex.Message);
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
                Debug.WriteLine("[****].[ERROR].[Capa CrudCodigoDeBarrasOrigen].[CreateOrigen]");
                throw new Exception("ERROR [Capa CrudCodigoDeBarrasOrigen].[CreateOrigen] " + ex.Message);
            }
        }

        public bool UpdateOrigen(ModeloCodigoDeBarrasOrigen actualizarRegistro)
        {
            try
            {
                using var db = conexion.ObtenerConexion();
                db.Open();

                string @update =
                    "UPDATE CodigoDeBarrasOrigen " +
                    "SET " +
                        "Radicado = @Radicado," +
                        "Id = @Id, " +
                        "Empleado = @Empleado," +
                        "Identificacion = @Identificacion," +
                        "Tipo_Documental = @Tipo_Documental," +
                        "Codigo_De_Barras_Recepcion = @Codigo_De_Barras_Recepcion " +
                        "WHERE Identificacion = @Identificacion ";

                using (SqlCommand updateSql = new SqlCommand(@update, db))
                {
                    updateSql.Parameters.AddWithValue("@Radicado", actualizarRegistro.Radicado);
                    updateSql.Parameters.AddWithValue("@Id", actualizarRegistro.Id);
                    updateSql.Parameters.AddWithValue("@Empleado", actualizarRegistro.Empleado);
                    updateSql.Parameters.AddWithValue("@Identificacion", actualizarRegistro.Identificacion);
                    updateSql.Parameters.AddWithValue("@Tipo_Documental", actualizarRegistro.TipoDocumental);
                    updateSql.Parameters.AddWithValue("@Codigo_De_Barras_Recepcion", actualizarRegistro.CodigoDeBarrasRecepcion);
                    updateSql.Parameters.AddWithValue("@CB_Documento", actualizarRegistro.CbDocumento ?? (object)DBNull.Value);
                    updateSql.Parameters.AddWithValue("@CB_Expediente", actualizarRegistro.CbExpediente ?? (object)DBNull.Value);
                    updateSql.Parameters.AddWithValue("@CB_Caja", actualizarRegistro.CbCaja ?? (object)DBNull.Value);
                    
                    int filasAfectadas = updateSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("[****].[ERROR].[Capa CrudCodigoDeBarrasOrigen].[UpdateOrigen]");
                throw new Exception("ERROR [Capa CrudCodigoDeBarrasOrigen].[UpdateOrigen] " + ex.Message);
            }
        }

        public bool DeleteOrigen(ModeloCodigoDeBarrasOrigen EliminarRegistro)
        {
            try
            {
                using var db = conexion.ObtenerConexion();
                db.Open();

                string @delete =
                    "DELETE FROM CodigoDeBarrasOrigen " +
                    "WHERE Identificacion = @Identificacion ";

                using (SqlCommand deleteSql = new SqlCommand(delete, db))
                {
                    deleteSql.Parameters.AddWithValue("@Identificacion", EliminarRegistro.Identificacion);

                    int filasAfectadas = deleteSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("[****].[ERROR].[Capa CrudCodigoDeBarrasOrigen].[DeleteOrigen]");
                throw new Exception("ERROR [Capa CrudCodigoDeBarrasOrigen].[DeleteOrigen] " + ex.Message);
            }
        }

    }
}
