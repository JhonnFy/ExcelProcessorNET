🧠 Conceptos importantes para la CapaControlador

La CapaControlador no tocará SQL ni aplicará reglas de negocio complejas.
Su trabajo será:
Recibir los datos desde la Interfaz de Usuario (UI).
Validar entradas básicas (por ejemplo: campos vacíos, formatos correctos).
Llamar a la CapaNegocio, pasando los datos ya validados.
Recibir la respuesta de la CapaNegocio (éxito, error, lista de objetos).
Preparar la información para que la UI pueda mostrarla de manera clara (mensajes, tablas, alertas).

<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/d05a382d-fd83-41c5-b2ca-18a7df441886" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/93eb87f5-6943-41dd-bd9c-4f709b80083c" />



