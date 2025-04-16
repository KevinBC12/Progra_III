// See https://aka.ms/new-console-template for more information
using Practica_1_Kevin_Barboza.Data;

bool salir = false;
GestionTareas gestionTareas = new GestionTareas();
List<Tarea> tarea = new List<Tarea>();
while (!salir)
{
    try
    {
        Console.WriteLine("------------ Menú Principal ----------");
        Console.WriteLine("| 1. Agregar Tarea                   |");
        Console.WriteLine("| 2. Mostrar Tarea                   |");
        Console.WriteLine("| 3. Marcar tarea como realizada     |");
        Console.WriteLine("| 4. Eliminar Tarea                  |");
        Console.WriteLine("| 5. Mostrar tareas por prioridad    |");
        Console.WriteLine("| 6. Salir del programa              |");
        Console.WriteLine("--------------------------------------");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion) {
            case 1:
                gestionTareas.AgregarTarea();
                break;
            case 2:
                gestionTareas.MostrarTareas();  
                break;
            case 3:
                gestionTareas.MarcarTareaComoRealizada();
                break;
            case 4:
                gestionTareas.EliminarTarea();
                break;
            case 5:
                gestionTareas.MostrarTareasPorPrioridad();
                break;
            case 6:
                Console.WriteLine("Saliendo del sistema de tareas!");
                salir = true;
                break;
            default:
                Console.WriteLine("Por favor escoger una opcion entre 1 y 5.");
                break;
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}