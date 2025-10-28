🧠 Conceptos importantes para la CapaNegocio

La CapaNegocio no tocará SQL ni conexión.
Su trabajo será:
Recibir la lista de objetos desde el Excel.
Llamar a CreateOrigen() de la CapaDatos para guardar los datos originales en Tabla1.
Aplicar reglas de negocio (por ejemplo mayúsculas, limpieza de texto).
Guardar los datos corregidos en Tabla2 (otra instancia de método Create de la CapaDatos, apuntando a la tabla de destino).
