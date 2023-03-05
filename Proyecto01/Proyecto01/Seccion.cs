using System;
using System.Collections.Generic;


namespace Proyecto01
{

	public class Seccion
	{
		Estudiantes[] Curso; 
		public Seccion(int cantidad)
		{
			Curso = new Estudiantes[cantidad];
		}
//		public void Mostrar()
//		{
//			foreach(Estudiantes x in Curso)
//				Console.WriteLine(x.ToString());
//		}

	}
}
