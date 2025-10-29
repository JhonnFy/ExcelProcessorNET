# ExcelSQLFusion

Aplicación desarrollada en .NET con arquitectura en capas (Data, Business, Controller, Interface), diseñada para **procesar y gestionar códigos de barras desde archivos Excel y almacenarlos en una base de datos SQL Server**.

---

## Tabla de Contenidos

1. [Interface](#Interface)  
2. [Características](#características)  
3. [Tecnologías](#tecnologías)  
4. [Arquitectura del Proyecto](#arquitectura-del-proyecto)  
5. [Instalación y Configuración](#instalación-y-configuración)  
6. [Reglas de Negocio](#Reglas-De-Negocio)  
7. [Pruebas](#pruebas)  
8. [Contribuciones](#contribuciones)  
9. [Licencia](#licencia)  
10. [Contacto](#contacto)

---

## Interface
<!-- Figura 1: Limpieza de Nombres -->
<figure align="center">
  <img width="800" alt="Vista de la Sabana de Datos - Limpieza de Nombres" src="https://github.com/user-attachments/assets/e593526a-740f-4602-a16e-69602de22022" />
  <figcaption><i><b>Figura.</b>1.</i></figcaption>
</figure>


<img width="800" alt="Vista de la Sabana de Datos - Limpieza de Nombres" src="https://github.com/user-attachments/assets/e593526a-740f-4602-a16e-69602de22022" />
<img width="950" alt="Vista de la Sabana de Datos - Limpieza de Cédulas" src="https://github.com/user-attachments/assets/d7078806-db38-4ed5-9aad-4049173510b4" />
<img width="700" alt="Arquitectura del Proceso de Limpieza" src="https://github.com/user-attachments/assets/1b63f62f-0203-449f-9623-bb17cd7b4708" />
---

## Características

- Lectura de archivos Excel (orígenes de datos) para extracción de códigos de barras y otros campos relevantes.  
- Limpieza y normalización de datos según reglas de negocio específicas.  
- Persistencia de datos en una base de datos SQL Server (capa de destino).  
- Arquitectura modular que permite futuras expansiones (por ejemplo, nuevas fuentes de datos, nuevos destinos, interfaz web, etc.).  
- Conjunto de pruebas automatizadas para asegurar calidad de código y estabilidad (capa de testing).  
- Documentación de reglas de negocio incorporadas.

---

## Tecnologías

- Lenguaje: C# (.NET)  
- Base de datos: Microsoft SQL Server  
- Arquitectura en capas:  
  - Capa de Datos (Data)  
  - Capa de Negocio (Business)  
  - Capa de Controladores (Controller)  
  - Capa de Interfaz de Usuario (Interface)
  - Capa Testing (Test)
- Herramientas de pruebas: MSTest  
- Escritura de scripts PowerShell para manipulación automatizada de datos (Creación de usuarios y asignación de cédulas de ciudadanía (CC) mediante scripts en PowerShell.)

---

## Arquitectura del Proyecto

El proyecto está organizado en carpetas que reflejan cada capa de responsabilidad:

- **CapaDatos** – Contiene los repositorios, entidades de datos y lógica de acceso a la base de datos.  
- **CapaNegocio** – Aquí reside la implementación de las reglas de negocio y el procesamiento de los datos.  
- **CapaControlador** – Contiene los controladores que actúan como intermediarios entre la interfaz de usuario y la lógica de negocio.  
- **CapaIgu (UI)** – Interfaz de usuario, que puede ser un proyecto de escritorio o solución moderna según implementación.  
- **CapaTesting** – Proyecto dedicado a pruebas unitarias e integración para asegurar la calidad del software.

Este enfoque permite una clara separación de responsabilidades, facilita el mantenimiento y posibilita la reutilización de componentes.

---

## Instalación y Configuración

1. Clona este repositorio en tu equipo:  
   ```bash
   git clone https://github.com/JhonnFy/ExcelSQLFusion.git
   
---

##  Reglas de Negocio
- [x] Regla 1: Limpieza de Nombres en la Sabana

**Descripción:**  
En la sabana de datos, los nombres de las personas incluyen un prefijo numérico.

**Ejemplo original:**
1. Santiago Jorge Ruiz Alvarez  
2. Isabella Jose Mendoza Castro  
3. Juan Mariana Castro Ruiz  
4. Carlos Jhon Gomez Ruiz  

**Requerimiento:**  
Se debe eliminar el **prefijo numérico** (incluyendo punto o espacio) de cada registro, conservando únicamente el nombre completo.

**Resultado esperado:**
- Santiago Jorge Ruiz Alvarez  
- Isabella Jose Mendoza Castro  
- Juan Mariana Castro Ruiz  
- Carlos Jhon Gomez Ruiz

- [x] Regla 2: Limpieza de Cédulas en la Sabana
**Descripción:**  
En la sabana, las cédulas de ciudadanía (CC) también incluyen un prefijo numérico.

**Ejemplo original:**
1. 241758461  
2. 7455039910  
3. 4478468449  
4. 4192283306  

**Requerimiento:**  
Se debe eliminar el **prefijo numérico** (incluyendo punto o espacio) de cada registro, conservando únicamente el número de cédula.

**Resultado esperado:**
- 241758461  
- 7455039910  
- 4478468449  
- 4192283306  

- [x] Regla 3: Formato del Campo *Tipo_Documental
**Descripción:**  
El campo **Tipo_Documental** se encuentra definido en formato *Camel Case* y debe mantenerse así.

**Ejemplo original:**
- Prorroga y Preaviso  
- Prorroga y Preaviso  
- Contrato de Trabajo  

**Regla:**  
Conservar el formato *Camel Case* tal como está definido.

**Resultado esperado:**
- Prorroga y Preaviso  
- Prorroga y Preaviso  
- Contrato de Trabajo  

- [x] Regla 4: Estilo del Tipo Documental “Carpeta Completa
**Descripción:**  
El tipo documental **Carpeta Completa** debe registrarse exclusivamente en mayúsculas.

**Regla:**  
Convertir a mayúsculas únicamente el valor **Carpeta Completa**.

**Resultado esperado:**
- CARPETA COMPLETA


<img width="581" height="366" alt="image" src="https://github.com/user-attachments/assets/e593526a-740f-4602-a16e-69602de22022" />
<img width="1360" height="546" alt="image" src="https://github.com/user-attachments/assets/d7078806-db38-4ed5-9aad-4049173510b4" />

<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/308df18e-75e3-4367-8ad9-a01adf4924ec" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/5e60d60b-f33f-40ac-a38e-f54cd94450b2" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/a9fc27e7-9e6e-4014-bfe3-d1a9ee30be29" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/6e5c1836-b77a-4ba8-ada3-6bb9255307b9" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/31d6aac8-cd57-45eb-8afe-647f79b8333e" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/424592e5-2048-4f56-96cd-5001ddbef56a" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/487107d6-c22c-4eaa-939d-a4ecf4473c8b" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/38dbc042-e71e-43aa-bfcf-7a75389653f2" />


<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/53b2ab09-095d-46bc-9c27-74ab3ef59d7e" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/1d2faecd-8c2e-496d-9206-4106c18f5bd5" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/ecc50874-63cf-4181-84a9-92cc0d57dc16" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/457e4aab-77ff-4688-ad42-2cb383d7bd1f" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/4960c67a-86f2-4d7f-b4f3-9c6644888a17" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/71c3971f-e7ce-48e8-ac55-e1ee27fea3c5" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/c402964d-5dc9-4fea-b0c0-1fba2bff6297" />

<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/295a0923-ee71-41f9-987c-afabfe403f05" />
<img width="667" height="442" alt="Arquitectura" src="https://github.com/user-attachments/assets/1b63f62f-0203-449f-9623-bb17cd7b4708" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/f06d5ad4-c254-437f-a696-da637f11c7ff" />

---

