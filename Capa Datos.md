# 🧱 Capa Datos – PROYECTO CÓDIGO DE BARRAS

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

## 🗄️ Estructura de la tabla CodigoDeBarrasOrigen

```sql
CREATE TABLE CodigoDeBarrasOrigen(
	IdIdentity int IDENTITY(1,1) NOT NULL,
	Radicado bigint,
	Id bigint,
	Empleado varchar(200),
	Identificacion varchar(200),
	Tipo_Documental varchar(200),
	Codigo_De_Barras_Recepcion varchar(200),
	CB_Documento varchar(200) NULL,
	CB_Expediente varchar(200) NULL,
	CB_Caja varchar(200) NULL
)
GO
```

## 🗄️ Estructura de la tabla CodigoDeBarrasDestino

```sql
CREATE TABLE CodigoDeBarrasDestino(
	IdIdentity int IDENTITY(1,1) NOT NULL,
	Radicado bigint NULL,
	Id bigint NULL,
	Empleado varchar(200) NULL,
	Identificacion varchar(200) NULL,
	Tipo_Documental varchar(200) NULL,
	Codigo_De_Barras_Recepcion varchar(200) NULL,
	CB_Documento varchar(200) NULL,
	CB_Expediente varchar(200) NULL,
	CB_Caja varchar(200) NULL
)
GO
```

---

## 🖼️ Vista previa en base de datos

<p align="center">
  <img width="1000" alt="Vista previa en base de datos" src="https://github.com/user-attachments/assets/d85db29b-5b8e-4957-ad31-d0fcb7a2e462" />
</p>

---

## 🧩 1️⃣ Crear la clase `CodigoDeBarras`

A continuación, se crea la clase modelo que representará las columnas de la tabla y servirá como entidad base para los métodos CRUD.

<p align="center">
  <img width="1000" alt="Clase CodigoDeBarras 1" src="https://github.com/user-attachments/assets/d10ab42c-1265-41e8-8d82-3a42f32ecb48" />
</p>
<p align="center">
  <img width="1000" alt="Clase CodigoDeBarras 2" src="https://github.com/user-attachments/assets/808ec9ca-da2a-4b45-9b5f-e09fc5801b1b" />
</p>
<p align="center">
  <img width="1000" alt="Clase CodigoDeBarras 3" src="https://github.com/user-attachments/assets/1e8bfd5f-55ca-4c2c-942f-14e41da70f46" />
</p>

---

## 🧮 2️⃣ Crear el modelo CRUD

Se implementan los métodos en la clase `CrudCodigoDeBarrasOrigen` para ejecutar las operaciones básicas sobre la base de datos.

<p align="center">
  <img width="1000" alt="Métodos CRUD principales" src="https://github.com/user-attachments/assets/ea1520d8-b9e1-4b01-a0e8-7b582dadaaf2" />
</p>
<p align="center">
  <img width="350" alt="Método Delete" src="https://github.com/user-attachments/assets/16ccb5c0-b352-43cc-8949-2cf3c2b771d0" />
</p>

---




## ✅ Checklist Final – Capa Datos

### 🧱 Métodos CRUD implementados
- ✅ `CreateOrigen()` → Inserta un nuevo registro  
- ✅ `ReadOrigen()` / `ReadId()` → Consulta registros  
- ✅ `UpdateOrigen()` → Actualiza registros existentes  
- ✅ `DeleteOrigen()` → Elimina registros por Identificación  

---

### 🧩 Estructura correcta
- Clase `Conexion` que obtiene la cadena de conexión y abre el `SqlConnection`  
- Clases CRUD separadas (por ejemplo: `CrudCodigoDeBarrasOrigen`)  
- Clases Modelo (`ModeloCodigoDeBarrasOrigen`) con propiedades bien definidas  
- Todos los métodos dentro de bloques `try-catch` con mensajes de error claros  
- Los comandos SQL usan parámetros (`@Parametro`), nunca concatenación directa  

---

### 💡 Buenas prácticas
- `using var db = conexion.ObtenerConexion();` → conexión limpia y cerrada automáticamente  
- `ExecuteNonQuery()` usado para `INSERT`, `UPDATE`, `DELETE`  
- `ExecuteReader()` usado para `SELECT`  
- Manejo correcto de tipos (`AddWithValue`, etc.)  
- Retorno de valores booleanos o listas según corresponda  

---

### 🧪 Pruebas unitarias (Capa Testing)
<p align="center">
	<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/67e615e5-5139-4e52-a23a-a95114d9d888" />
</p>

- ✔ `Test_CreateOrigen`  
- ✔ `Test_ReadOrigen`  
- ✔ `Test_UpdateOrigen`  
- ✔ `Test_DeleteOrigen`  

🟢 **Todos los tests pasan correctamente (✔ Passed)**



---

## 🖼️ CapaDatos terminada

<p align="center">
	<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/036f90c8-5c01-4781-9593-d9052ff2b5bd" />
</p>

---
