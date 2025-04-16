using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Kevin_Barboza.Data
{
    public class GestionTareas
    {
        List<Tarea> tarea = new List<Tarea>();
        //CREAR
        public void AgregarTarea()
        {
            Console.WriteLine("Ingrese el nombre de la nueva tarea:");
            string nombreTarea = Console.ReadLine();
            Console.WriteLine("Seleccione el tipo de tarea \n 1- Tarea Simple: \n 2- Tarea con Fecha \n 3- Tarea con Prioridad ");
            int tipoTarea = int.Parse(Console.ReadLine());
            switch (tipoTarea)
            {
                case 1:
                    tarea.Add(new TareaSimple(nombreTarea));
                    Console.WriteLine("La tarea simple fue agregada con exito!");
                    break;
                case 2:
                    Console.WriteLine("Escriba la fecha de entrega de la tarea utilizando el formato dd-mm-AA:");
                    string FechaVencimiento = Console.ReadLine();
                    DateTime Resultado;
                    DateTime.TryParse(FechaVencimiento, out Resultado);
                    if (!Resultado.Equals(DateTime.MinValue))
                    {
                        tarea.Add(new TareaConFecha(nombreTarea, Resultado));
                        Console.WriteLine("La tarea con fecha fue agregada con exito!");
                    }
                    else
                    {
                        Console.WriteLine("Error! Se debe escribir una fecha valida.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Escriba la Prioridad de la tarea ya sea Alta, Media o Baja");
                    string TareaPrioridad = Console.ReadLine();
                    tarea.Add(new TareaPrioritaria(nombreTarea,TareaPrioridad));
                    Console.WriteLine("La tarea con prioridad fue agregada con exito!");
                    break;
                    default:
                    Console.WriteLine("Seleccione una categoria correcta.");
                    break;
            }
            
           
        }
        //LEER
        public void MostrarTareas()
        {
            Console.WriteLine("Lista de Tareas:");
            foreach (var Tarea in tarea)
            {
                Tarea.MostrarTarea();
            }
        }
        //MarcarTareaComoRealizada
        public void MarcarTareaComoRealizada()
        {
            Console.WriteLine("Escriba el nombre de la tarea que quiera marcar como completada");
            string Completada = Console.ReadLine();
            foreach (var Tarea in tarea)
            {
                if(Tarea.Nombre == Completada)
                {
                    Tarea.CompletarTarea(); 
                    Console.WriteLine($"La tarea {Completada} se ha marcado como completada");
                }
            }
        }
        //Eliminar
        public void EliminarTarea()
        {
            Console.WriteLine("Ingrese el nombre de la tarea a eliminar:");
            string nombre = Console.ReadLine();
            var Tarea = tarea.Find(t=> t.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (Tarea != null) {
            tarea.Remove(Tarea);
                Console.WriteLine($"Tarea  {nombre} eliminado de la lista de tareas.");
            }
            else
            {
                Console.WriteLine($"Tarea {nombre} no encontrada.");
            }
        }
        //Mostrar las tareas ya sean de prioridad Baja, Media o Alta
        public void MostrarTareasPorPrioridad()
        {
            Console.WriteLine("Escriba el tipo de prioidad de la tarea ");
            string TareaPrioridad = Console.ReadLine().ToUpper();
            foreach (var Tarea in tarea) { 
                //Se busca en las tareas que sean de tipo prioridad 
                if(Tarea.GetType() == typeof(TareaPrioritaria))
                {
                    //Se hace un temporal del objeto para compararlo con el tipo de prioridad escrito por el usuario
                    // ahora si ese temporal es igual en tipo de prioridad solo se mostraran las tareas de esa prioridad.
                    TareaPrioritaria tempTarea = (TareaPrioritaria)Tarea;
                    if(tempTarea.TareaPrioridad == TareaPrioridad)
                    {
                        tempTarea.MostrarTarea();
                    }
                }
                
            }
        }
    }
}