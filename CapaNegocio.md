🧠 Conceptos importantes para la CapaNegocio

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
