using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Kevin_Barboza.Data
{
    public class TareaConFecha : Tarea
    {
        //AtributoAdicional
        public DateTime FechaVencimiento { get; set; }
    
        public TareaConFecha(string nombre, DateTime fechaVencimiento) :
        base (nombre, "Tarea con Fecha")
        {
            FechaVencimiento = fechaVencimiento;
        }
        public override void MostrarTarea()
        {
            if (Completada == true)
            {
                Console.WriteLine($"-Tarea {Nombre}: -Tipo: {TipoTarea} -Fecha de Vencimiento: {FechaVencimiento} Estado: Completada");
            }
            else
            {
                Console.WriteLine($"-Tarea {Nombre}: -Tipo: {TipoTarea} -Fecha de Vencimiento: {FechaVencimiento} Estado: Sin Completar");
            }
        }
    }
}
