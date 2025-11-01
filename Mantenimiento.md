¿Orden Para Agregar Nuevos Metodos?

Creare un metodo que limpie la tabla en la dB
--DELETE FROM CodigoDeBarrasOrigen
--DBCC CHECKIDENT ('CodigoDeBarrasOrigen', RESEED, 0);


1-CapaDatos Crear el metodo
public void LimpiarCodigoDeBarrasOrigen()
{
    using (var db = conexion.ObtenerConexion())
        try
    {
        db.Open();
            string @query =
                "DELETE FROM CodigoDeBarrasOrigen " +
                "DBCC CHECKIDENT ('CodigoDeBarrasOrigen', RESEED, 0)";

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

2-CapaNegocio MetodoIntermedio
public void LimpiarOrigen()
{
    var datos = new DatosOrigen();
    datos.LimpiarTablaOrigen();
}


3-CapaControladorOrigen
objCapaNegocioOrigen.LimpiarCodigoDeBarrasOrigen();
Debug.WriteLine("[****].[OK].[CapaControladorOrigen].[ImportarDesdeExcel].[Tabla CodigoDeBarrasOrigen limpiada]");
