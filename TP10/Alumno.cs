using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10
{
    class Alumno
    {
        public long DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public Alumno(long DNI, string apellido, string nombre)
        {
            this.DNI = DNI;
            this.Apellido = apellido;
            this.Nombre = nombre;
        }
        public Alumno(string linea)
        {
            var datos = linea.Split(',');
            DNI = long.Parse(datos[0]);
            Apellido = datos[1];
            Nombre = datos[2];

        }
        public string ObtenerRegistro()
        {
            return String.Format("{0},{1},{2}", this.DNI, this.Apellido, this.Nombre);
        }
    }
}
