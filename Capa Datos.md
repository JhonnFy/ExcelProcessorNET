En esta capa el objetivo principal es conectarse a la base de datos y exponer métodos para leer/escribir datos, sin mezclar reglas de negocio ni lógica de interfaz.

Columnas Del Excel:
RADICADO //Es una columna con datos del Excel Origen
ID //Es una columna con datos del Excel Origen
EMPLEADO //Es una columna con datos del Excel Origen
IDENTIFICACION //Es una columna con datos del Excel Origen
TIPO_DOCUMENTAL //Es una columna con datos del Excel Origen
CODIGO_DE_BARRAS_RECEPCION //Es una columna con datos del Excel Origen
CB Documento //Es una columna con datos del Excel Origen Viene vacia es la quevamos a llenar
CB Expediente //Es una columna con datos del Excel Origen Viene vacia es la quevamos a llenar
CB Caja //Es una columna con datos del Excel Origen Viene vacia es la quevamos a llenar

Atributos de la tabla en db:
--CREATE TABLE CodigoDeBarrasData (
--    IdIdentity INT IDENTITY(1,1) NOT NULL,
--    RADICADO BIGINT,
--    ID BIGINT,
--    EMPLEADO VARCHAR(200),
--    IDENTIFICACION VARCHAR(200),
--    TIPO_DOCUMENTAL VARCHAR(200),
--    CODIGO_DE_BARRAS_RECEPCION VARCHAR(200) NULL,
--    CB_Documento VARCHAR(200) NULL,
--    CB_Expediente VARCHAR(200) NULL,
--    CB_Caja VARCHAR(200) NULL
--);

<img width="1360" height="546" alt="image" src="https://github.com/user-attachments/assets/d85db29b-5b8e-4957-ad31-d0fcb7a2e462" />

# 1 Crear La Clase CodigoDeBarras
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/d10ab42c-1265-41e8-8d82-3a42f32ecb48" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/808ec9ca-da2a-4b45-9b5f-e09fc5801b1b" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/1e8bfd5f-55ca-4c2c-942f-14e41da70f46" />

# 2 Crear Los Metodos
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/ea1520d8-b9e1-4b01-a0e8-7b582dadaaf2" />

# 3 Instalar Paquetes
Install-Package Microsoft.Data.SqlClient
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/c62477f1-99b8-47de-88da-8f4ee8a0bb41" />

Install-Package System.Configuration.ConfigurationManager
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/480d49c8-f81b-42b5-b498-2689666ee5d4" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/12f52861-c417-45b6-b735-d0737732f540" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/65e2c339-7bbb-4796-9839-c1d1fa817a09" />
Instalar paquetes desarrolaldos por Microsoft
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/b2c65458-a471-49e8-bc4f-353512fb33f5" />


