# 🧱 Capa Datos – Proyecto Código de Barras

En esta capa el **objetivo principal** es conectarse a la base de datos y exponer métodos para **leer, escribir, actualizar y eliminar datos**, **sin mezclar reglas de negocio ni lógica de interfaz**.

---

## 📊 Columnas del archivo Excel de origen

- **RADICADO** → Columna con datos del Excel origen  
- **ID** → Columna con datos del Excel origen  
- **EMPLEADO** → Columna con datos del Excel origen  
- **IDENTIFICACION** → Columna con datos del Excel origen  
- **TIPO_DOCUMENTAL** → Columna con datos del Excel origen  
- **CODIGO_DE_BARRAS_RECEPCION** → Columna con datos del Excel origen  
- **CB Documento** → Columna vacía en el Excel origen — se llenará durante el proceso  
- **CB Expediente** → Columna vacía en el Excel origen — se llenará durante el proceso  
- **CB Caja** → Columna vacía en el Excel origen — se llenará durante el proceso  

---

## 🗄️ Estructura de la tabla en base de datos

```sql
CREATE TABLE CodigoDeBarrasData (
    IdIdentity INT IDENTITY(1,1) NOT NULL,
    RADICADO BIGINT,
    ID BIGINT,
    EMPLEADO VARCHAR(200),
    IDENTIFICACION VARCHAR(200),
    TIPO_DOCUMENTAL VARCHAR(200),
    CODIGO_DE_BARRAS_RECEPCION VARCHAR(200) NULL,
    CB_Documento VARCHAR(200) NULL,
    CB_Expediente VARCHAR(200) NULL,
    CB_Caja VARCHAR(200) NULL
);
```
🖼️ Vista previa en base de datos
<img width="1360" height="546" alt="image" src="https://github.com/user-attachments/assets/d85db29b-5b8e-4957-ad31-d0fcb7a2e462" />
<img width="1360" height="546" alt="image" src="https://github.com/user-attachments/assets/d85db29b-5b8e-4957-ad31-d0fcb7a2e462" />

# 1 Crear La Clase CodigoDeBarras
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/d10ab42c-1265-41e8-8d82-3a42f32ecb48" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/808ec9ca-da2a-4b45-9b5f-e09fc5801b1b" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/1e8bfd5f-55ca-4c2c-942f-14e41da70f46" />

# 2 Crear Los Metodos
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/ea1520d8-b9e1-4b01-a0e8-7b582dadaaf2" />
<img width="326" height="470" alt="image" src="https://github.com/user-attachments/assets/16ccb5c0-b352-43cc-8949-2cf3c2b771d0" />



🧩 Checklist final – Capa Datos
✅ Métodos CRUD implementados:
 CreateOrigen() → Inserta un nuevo registro
 ReadOrigen() / ReadId() → Consulta registros
 UpdateOrigen() → Actualiza registros existentes
 DeleteOrigen() → Elimina registros por Identificación

✅ Estructura correcta:
 Clase Conexion que obtiene la cadena de conexión y abre el SqlConnection
 Clases CRUD separadas (por ejemplo, CrudCodigoDeBarrasOrigen)
 Clases Modelo (ModeloCodigoDeBarrasOrigen) con propiedades bien definidas
 Todos los métodos están dentro de bloques try-catch con mensajes de error claros
 Los comandos SQL usan parámetros (@Parametro), nunca concatenación directa

✅ Buenas prácticas:
 using var db = conexion.ObtenerConexion(); → conexión limpia y cerrada automáticamente
 ExecuteNonQuery() usado para INSERT, UPDATE, DELETE
 ExecuteReader() usado para SELECT
 Manejo correcto de tipos (AddWithValue, etc.)
 Retorno de valores booleanos o listas según corresponda

✅ Pruebas unitarias (Capa Testing):
 Test de CreateOrigen
 Test de ReadOrigen
 Test de UpdateOrigen
 Test de DeleteOrigen
 Todos los tests pasan correctamente (✔ Passed)

