using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Kevin_Barboza.Data
{
    internal class TareaSimple : Tarea
    {
        public TareaSimple(string nombre) :
        base(nombre, "Tarea Simple")
        {
        }
        public override void MostrarTarea()
        {
            if (Completada==true)
            {
                Console.WriteLine($"-Tarea {Nombre}: -Tipo: {TipoTarea} Estado: Completada");
            }
            else {
                Console.WriteLine($"-Tarea {Nombre}: -Tipo: {TipoTarea} Estado: Sin completar");
            }
           
        }
    }
}
