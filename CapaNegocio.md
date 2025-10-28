🧠 Conceptos importantes para la CapaNegocio

<img width="752" height="395" alt="image" src="https://github.com/user-attachments/assets/fa0dfaf7-83a2-425b-8a08-5b3697f5a449" />


La CapaNegocio no tocará SQL ni conexión.
Su trabajo será:
Recibir la lista de objetos desde el Excel.
Llamar a CreateOrigen() de la CapaDatos para guardar los datos originales en Tabla1.
Aplicar reglas de negocio (por ejemplo mayúsculas, limpieza de texto).
Guardar los datos corregidos en Tabla2 (otra instancia de método Create de la CapaDatos, apuntando a la tabla de destino).


🧩 CapaNegocioOrigen – responsabilidad
Recibir la lista de objetos del Excel (cada objeto = fila).
Guardar los objetos tal como vienen en la Tabla1 (origen) usando la CapaDatos.
No aplica reglas ni transforma nada todavía.
Concepto clave: una capa = una responsabilidad. Así puedes mantener orden y claridad.

🧩 CapaNegocioDestino – responsabilidad
Recibe los objetos desde CapaNegocioOrigen o lee desde Tabla1.
Aplica reglas de negocio:
Transformaciones (mayúsculas/minúsculas, limpieza de texto, validaciones).
Llama a la CapaDatos para guardar los registros corregidos en la Tabla2 (destino).
Retorna el estado de la operación al Controlador o interfaz.


1- Crear La clase
2- Agregar La Referencia
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/b881ed52-89b7-44dd-b92a-ea4be7b1f972" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/8075209c-c7a9-4e81-9e55-a043a4ac6051" />

