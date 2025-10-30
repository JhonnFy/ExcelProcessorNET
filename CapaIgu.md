Capa Igu

#  Borrar el fomulario que viene por defevto en esta clase.
#  crear Un Formulario con el nombre de la App. Tipo AppRun o similar

<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/5f76b323-fa38-4083-9863-6fcd43be1af4" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/0f233f61-fab3-41a4-9b19-f79e7a966b75" />


<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/290c57c0-ac71-4377-abbc-6a82f45b0041" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/80f572bc-0181-469f-841c-bc88f10cc2f2" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/4bd4b71d-ce2a-49cc-915e-c62884130223" />

<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/a0b09db7-3da7-4d32-bc38-654543308877" />

Importante:
Revisar el nombre del servidor: SELECT @@SERVERNAME AS NombreServidor;


🧩 Funciones que debe cumplir tu Capa IGU

Importar el archivo Excel.
Permitir al usuario seleccionar un archivo Excel desde su sistema.
Leer el contenido del Excel (usando por ejemplo ClosedXML, EPPlus, o Microsoft.Office.Interop.Excel).
Convertir cada fila del Excel en una lista de objetos ModeloCodigoDeBarrasOrigen.
Enviar los datos a la Capa Controlador.
Llamar al método GuardarRegistrosOrigen(List<ModeloCodigoDeBarrasOrigen> listaExcel) de tu clase CapaControladorOrigen.
Mostrar resultados al usuario.
Mostrar cuántos registros fueron insertados correctamente.
Mostrar mensajes de error si ocurre alguna excepción.


1-Agregar las referencias de las capas:
CapaControlador
CapaNegocio
CapaDatos
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/855c6943-421e-4202-a97c-1d398a932bba" />

2-Instalar La Libreria Para Leer Excel Install-Package ClosedXML
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ae045678-9cf4-4c08-b819-3f69668e0c13" />
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/1aba6990-fc78-4026-9ea8-dce5a783c585" />

3-Diseñar la Igu
<figure align="center">
  <img width="617" height="395" alt="image" src="https://github.com/user-attachments/assets/e898f146-2d11-40e2-b020-460f170e737f" />
</figure>

Agregar el DataGridView

<figure align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/7daac9a3-013e-4b56-898f-ae5b256e4c39" />
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/a13887a1-8381-43e0-b74e-7b2dc9de7fe8" />
</figure>

Crear un metodo para personalizar el DataGridView

