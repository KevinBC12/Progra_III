# Programa de Gestión de Tareas Personales Pendientes

Este programa es una práctica para la materia Programación III, desarrollado por estudiantes del primer cuatrimestre del año 2025. 
Su objetivo es gestionar tareas pendientes de un usuario utilizando Programación Orientada a Objetos (POO).

Objetivo del Programa
El propósito de este proyecto es desarrollar una aplicación que permita a los usuarios gestionar sus tareas pendientes de manera eficiente. 
A través de este programa, el usuario podrá:
•	Agregar nuevas tareas.
•	Eliminar tareas ya no necesarias.
•	Listar las tareas según su prioridad o en orden general.
•	Marcar tareas como completadas.

 Estructura y Funcionalidad
Este programa sigue los principios de Programación Orientada a Objetos (POO), utilizando conceptos como:
•	Herencia: Se utilizan clases base y clases derivadas para representar distintos tipos de tareas.
•	Polimorfismo: Métodos sobrescritos en las clases hijas para comportamientos específicos.
•	Encapsulamiento: La información de cada tarea está protegida para evitar modificaciones no deseadas.

Las principales clases del programa son:
Tareas: Clase Padre implementa el metodo abstracto MostrarTareas y el metodo CompletarTarea.
TareaSimple: Clase Hija se encarga de sobreescribir el metodo de MostrarTareapara mostrando la info de una tarea simple.
TareaConFecha: Clase Hija se encarga de sobreescribir el metodo MostrarTarea utilizando un atributo de tipo DateTime el cual sera mostrado junto a su tipo de tarea.
TareaPrioritaria: Clase Hija se encarga de sobreescribir el metodo MostrarTarea utilizando un atributo propio de tipo string TareaPrioridad el cual nos mostrara la
prioridad de la tarea.
GestionarTarea: En esta se implementaran los metodos necesarios para cada funcion que pueda elegir el usuario para que sea realizada de manera eficiente y facil. 

Requisitos del Sistema
Para ejecutar este programa, es necesario contar con:
Lenguaje: C#
Framework: .NET 8.0 