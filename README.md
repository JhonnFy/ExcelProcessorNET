# 🏗 Arquitectura del Proyecto — ExcelSQLFusion

El proyecto está organizado en capas para separar responsabilidades y facilitar el mantenimiento.

- 🖥 **Interfaz (UI) — CapaIgu**  - [README CapaIgu](./Capa%20Igu.md)

- 🎼 **Capa Controlador**
  - Coordina la lógica entre Negocio y UI
  - [README Capa Controlador](./Capa%20Controlador.md)

- 🧩 **Capa Negocio**
  - Aplica reglas de negocio sobre los datos
  - [README Capa Negocio](./Capa%20Negocio.md)

- 💾 **Capa Datos**
  - Gestiona Base de Datos
  - [README Capa Datos Origen](./Capa%20Datos%20Origen.md)
  - [README Capa Datos Destino](./Capa%20Datos%20Destino.md)









## Documentación de Capas

- [Capa Datos Origen](https://github.com/JhonnFy/ExcelSQLFusion/blob/main/Capa%20Datos%20Origen.md)
- [Capa Datos Destino](https://github.com/JhonnFy/ExcelSQLFusion/blob/main/Capa%20Datos%20Destino.md)



# 📘 Reglas de Negocio

---

Los nombres y números de identificación han sido generados automáticamente mediante PowerShell. No corresponden a datos reales.

1. CapaDatos
2. CapaNegocio
3. CapaControlador 🎼
4. CapaIgu

## 🧩 Regla 1 — Limpieza de Nombres en la Sabana

**Descripción:**  
En la sabana de datos, los nombres de las personas incluyen un prefijo numérico.

**Ejemplo original:**
1. Santiago Jorge Ruiz Alvarez  
2. Isabella Jose Mendoza Castro  
3. Juan Mariana Castro Ruiz  
4. Carlos Jhon Gomez Ruiz  

**Regla:**  
Se debe eliminar el **prefijo numérico** (incluyendo punto o espacio) de cada registro, conservando únicamente el nombre completo.

**Resultado esperado:**
- Santiago Jorge Ruiz Alvarez  
- Isabella Jose Mendoza Castro  
- Juan Mariana Castro Ruiz  
- Carlos Jhon Gomez Ruiz  

---

## 🧩 Regla 2 — Limpieza de Cédulas en la Sabana

**Descripción:**  
En la sabana, las cédulas de ciudadanía (CC) también incluyen un prefijo numérico.

**Ejemplo original:**
1. 241758461  
2. 7455039910  
3. 4478468449  
4. 4192283306  

**Regla:**  
Se debe eliminar el **prefijo numérico** (incluyendo punto o espacio) de cada registro, conservando únicamente el número de cédula.

**Resultado esperado:**
- 241758461  
- 7455039910  
- 4478468449  
- 4192283306  

---

## 🧩 Regla 3 — Formato del Campo *Tipo_Documental*

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

---

## 🧩 Regla 4 — Estilo del Tipo Documental “Carpeta Completa”

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

