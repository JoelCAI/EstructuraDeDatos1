using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos1
{
    internal class Persona
    {
		private int _documento;
		private string _nombre;
		private string _apellido;
		private DateTime _fechaNacimiento;

		public int Documento
		{
			get { return this._documento; }
			set { this._documento = value; }
		}

		public string Nombre
		{
			get { return this._nombre; }
			set { this._nombre = value; }
		}

		public string Apellido
		{
			get { return this._apellido; }
			set { this._apellido = value; }
		}
		public DateTime FechaNacimiento
		{
			get { return this._fechaNacimiento; }
			set { this._fechaNacimiento = value; }
		}

		

		public Persona(int documento,string nombre, string apellido, DateTime fechaNacimiento)
		{

			this._documento = documento;
			this._nombre = nombre;
			this._apellido = apellido;
			this._fechaNacimiento = fechaNacimiento;

		}
	}
}
