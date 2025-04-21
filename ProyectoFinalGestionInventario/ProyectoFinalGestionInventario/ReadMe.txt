# Sistema de Gestion de Inventarios

Este programa es parte del proyecto final para la materia Programacion III, desarrollado por estudiantes del primer cuatrimestre del año 2025. 
Su objetivo es gestionar Inventario de una empresa utilizando una conexión de SQL server que es nuestra base de datos a un lenguaje C#.

Objetivo del Programa
El proposito de este proyecto es desarrollar una aplicacion que permita a los usuarios de una empresa gestionar su Inventario a travez de una pagina web 
de manera eficiente añadiendo bootsrap para estilizar la pagina para que sea mas user friendly. 
A traves de este programa, el usuario podra :
 	Agregar nuevos Productos al Inventario.
	Añadir clientes para que estos obtengan productos.
 	Eliminar Productos ya vendidos.
	Editar clientes y productos de las tablas.
 	Registros de usuarios para el acceso a ciertas partes de la pagina web.
 	Hacer una conexión muchos a muchos entre clientes y productos.

Las principales clases del programa son:
Cliente: Esta tendrá todos los atributos necesarios de clientes que podrán ser editados, eliminados, creados y ver sus detalles por medio del sistema CRUD
que se crean en su controlador 
Productos: Esta tendrá todos los atributos necesarios de productos que podrán ser editados, eliminados, creados y ver sus detalles por medio del sistema CRUD
que se crean en su controlador 
ClienteProducto: Esta hace la conexión entre los clientes y productos, siendo esta nuestra tabla intermedia la cual tendrá los atributos para conectar de manera
eficiente ambas clases
ApplicationDbContext: Esta clase nos permite utilizar el DbContext dentro de nuestro proyecto dando a la clase Program la conexión directa a la base de datos. 


Requisitos del Sistema
Para ejecutar este programa, es necesario contar con:
Lenguaje: C#
Framework: .NET 8.0 
Base de datos: SQL Server Managment Studio 20
Tener las librerías NutGet intaladas en su version 8.0.14 de : 
-Microsoft.EntityFrameWorkCore.SqlServer
-Microsoft.EntityFrameWorkCore.Tools
-Microsoft.AspNetCore.Identity.UI
-Microsoft.VisualStudio.Web.CodeGeneration.Design
- bootstrap por "The Bootstrap Authors" en su version de 5.3.5 