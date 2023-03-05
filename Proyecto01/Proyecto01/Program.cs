using System;

namespace Proyecto01
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			string Nombres;
			int Codigo,Cedula,Edad,Opcion;
			bool Sexo,Activo;
			do{
			
			Console.WriteLine("Ingrese los datos del estudiante que desea agregar");
			//Nombre del Estudiante
			Console.WriteLine("Ingresa el Nombre del Estudiante");
				Nombres = Console.ReadLine();
			//Cedula del Estudiante
			Console.WriteLine("Ingresa la Cedula del Estudiante");
				Cedula = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ingresa la Edad del Estudiante");
				Edad = Convert.ToInt32(Console.ReadLine());
			//Mostrar Datis del estudiante
			Console.Clear();

				Seccion a = new Seccion(1);
			Estudiantes t = new Estudiantes(1,Nombres,Cedula,Edad,true,true);
			
			Console.WriteLine(t.ToString());
			Console.WriteLine(a.ToString());
			//Salir del Sistema
			Console.WriteLine("Selecciona una Opcion");
				Opcion = Convert.ToInt32(Console.ReadLine());	
			}while(Opcion==1);

			
			//Para parar la consola
			Console.Write("Precione una Tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}