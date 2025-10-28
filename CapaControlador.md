🧠 Conceptos importantes para la CapaControlador

La CapaControlador no tocará SQL ni aplicará reglas de negocio complejas.
Su trabajo será:
Recibir los datos desde la Interfaz de Usuario (UI).
Validar entradas básicas (por ejemplo: campos vacíos, formatos correctos).
Llamar a la CapaNegocio, pasando los datos ya validados.
Recibir la respuesta de la CapaNegocio (éxito, error, lista de objetos).
Preparar la información para que la UI pueda mostrarla de manera clara (mensajes, tablas, alertas).
