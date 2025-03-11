# Flight Plan Simulator

Este es un simulador de planes de vuelo desarrollado como parte de la asignatura *Informática 2* de la universidad. El programa permite simular la trayectoria de varios aviones a partir de planes de vuelo proporcionados por el usuario. Durante la simulación, el programa verifica si existen interferencias entre los vuelos y muestra información relevante sobre la seguridad y el ciclo de los aviones.

## Características

- **Añadir Planes de Vuelo**: El usuario puede añadir planes de vuelo proporcionando información como el identificador del vuelo, la compañía, la velocidad y las coordenadas de inicio y destino.
- **Simulación de Trayectorias**: El programa simula las trayectorias de los aviones, moviéndolos de acuerdo con las coordenadas proporcionadas en los planes de vuelo.
- **Verificación de Interferencias**: Durante la simulación, el sistema verifica si las trayectorias de los aviones se cruzan, lo que podría causar interferencias.
- **Interfaz de Usuario**: La aplicación incluye una interfaz gráfica basada en formularios que permite interactuar con el programa de manera intuitiva.
- **Gestión de Planes de Vuelo**: La clase `FPList` se encarga de almacenar y gestionar una lista de planes de vuelo, permitiendo añadir nuevos vuelos, obtener detalles de los vuelos existentes y mover todos los vuelos en el espacio cartesiano.

## Requisitos

- Visual Studio o cualquier otro IDE compatible con C#.
- .NET Framework.

## Uso

1. **Añadir un Plan de Vuelo**: Selecciona la opción "Añadir Plan" en el menú. Luego, se abrirá un formulario donde podrás ingresar la información del vuelo. El plan será añadido a la lista.
2. **Simular los Vuelos**: Selecciona la opción "Simular" para visualizar cómo se mueven los aviones y comprobar si hay interferencias entre ellos.
3. **Configurar la Simulación**: Puedes ajustar parámetros como la distancia de seguridad y el tiempo de ciclo a través de la opción "Configuración de Simulación".

## Estructura del Código

El proyecto está dividido en varias clases:

- **Formularios**:
  - `Principal`: La ventana principal de la aplicación, donde se gestionan las acciones del usuario (añadir planes de vuelo, configurar la simulación y ejecutar la simulación).
  - `NuevoPlan`: Un formulario para ingresar los datos de un nuevo plan de vuelo.
  - `Simulador`: Un formulario para simular los movimientos de los aviones.
  - `InfoSimulacion`: Un formulario para configurar la distancia de seguridad y el tiempo de ciclo de la simulación.

- **Clases**:
  - `FlightPlan`: Representa un plan de vuelo, con información sobre el vuelo, las coordenadas de inicio y destino, y métodos para mover el avión en el espacio cartesiano.
  - `FPList`: Gestiona una lista de planes de vuelo, permitiendo añadir nuevos vuelos, obtener información de vuelos específicos, mover todos los vuelos en el espacio y obtener el número total de planes de vuelo.

