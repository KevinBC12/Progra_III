using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Kevin_Barboza.Data
{
    public abstract class Tarea
    {
        //Atributos 
        public string Nombre { get; set; }  
        public string TipoTarea { get; set; }
        public bool Completada {  get; set; }

        //Constructor
        public Tarea(string nombre, string tareaTipo ) { 
            Nombre = nombre;
            TipoTarea = tareaTipo;
            Completada = false;    
        }
        public abstract void MostrarTarea();

        public void CompletarTarea()
        {
            Completada = true;
        }

    }
}
