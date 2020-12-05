using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10
{
    class Nota
    {
        public long DNI { get; set; }
        public int Notas { get; set; }
        public string Fecha { get; set; }
        public Nota(long DNI, int nota, string fecha)
        {
            this.DNI = DNI;
            this.Notas = nota;
            this.Fecha = fecha;
        }
        public Nota(string linea)
        {
            var datos = linea.Split(';');
            DNI = long.Parse(datos[0]);
            Notas = int.Parse(datos[1]);
            Fecha = datos[2];
        }
        public string ObtenerRegistro()
        {
            return String.Format("{0};{1};{2}", this.DNI, this.Notas, this.Fecha);
        }
    }
}
