# Programa de Gesti�n de Tareas Personales Pendientes

Este programa es una pr�ctica para la materia Programaci�n III, desarrollado por estudiantes del primer cuatrimestre del a�o 2025. 
Su objetivo es gestionar tareas pendientes de un usuario utilizando Programaci�n Orientada a Objetos (POO).

Objetivo del Programa
El prop�sito de este proyecto es desarrollar una aplicaci�n que permita a los usuarios gestionar sus tareas pendientes de manera eficiente. 
A trav�s de este programa, el usuario podr�:
�	Agregar nuevas tareas.
�	Eliminar tareas ya no necesarias.
�	Listar las tareas seg�n su prioridad o en orden general.
�	Marcar tareas como completadas.

 Estructura y Funcionalidad
Este programa sigue los principios de Programaci�n Orientada a Objetos (POO), utilizando conceptos como:
�	Herencia: Se utilizan clases base y clases derivadas para representar distintos tipos de tareas.
�	Polimorfismo: M�todos sobrescritos en las clases hijas para comportamientos espec�ficos.
�	Encapsulamiento: La informaci�n de cada tarea est� protegida para evitar modificaciones no deseadas.

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