using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Kevin_Barboza.Data
{
 
    public class TareaPrioritaria : Tarea
    {
        //Atributo Addicional
        public string TareaPrioridad{ get; set; }
        public TareaPrioritaria(string nombre,string TarePrioridad) :
        base(nombre, "Tarea con Prioridad")
        {
            TareaPrioridad = TarePrioridad.ToUpper();
        }
        public override void MostrarTarea()
        {
            if (Completada == true) {
                Console.WriteLine($"-Tarea {Nombre}: -Tipo: {TipoTarea}  -Prioridad de la tarea: {TareaPrioridad} Estado: Completada");
            }
            else
            {
                Console.WriteLine($"-Tarea {Nombre}: -Tipo: {TipoTarea}  -Prioridad de la tarea: {TareaPrioridad} Estado: Sin Completar");
            }
                
        }
    }
}
