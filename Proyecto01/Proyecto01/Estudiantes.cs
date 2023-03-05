using System;

namespace Proyecto01
{
	public class Estudiantes
	{
		public int Codigo;
		public string Nombre;
		public int Cedula;
		public int Edad;
		public bool Sexo;
		public bool Activo;
		public Estudiantes(int Codigo, string Nombre, int Cedula, int Edad, bool Sexo,bool Activo)
		{
			this.Codigo = Codigo;
			this.Nombre = Nombre;
			this.Cedula = Cedula;
			this.Edad = Edad;
			this.Sexo = Sexo;
			Activo = true;
			
		}
		public override string ToString()
		{
			return string.Format("[Estudiantes Codigo={0}, Nombre={1}, Cedula={2}, Edad={3}, Sexo={4}, Activo={5}]", Codigo, Nombre, Cedula, Edad, Sexo, Activo);
		}
		
	

	}
}
