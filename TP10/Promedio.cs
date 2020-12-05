using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10
{
    class Promedio
    {
        public long DNI { get; set; }
        public string Apellidos { get; set; }
        public double Promedios { get; set; }
        public int N_notas { get; set; }
        public Promedio()
        {
        }
        public Promedio(long DNI, string apell, double promedio, int N_notas)
        {
            this.DNI = DNI;
            this.Apellidos = apell;
            this.Promedios = promedio;
            this.N_notas = N_notas;
        }
        
        public Promedio(string linea)
        {
            var datos = linea.Split(';');
            DNI = long.Parse(datos[0]);
            Apellidos = datos[1];
            Promedios = double.Parse(datos[2]);
            N_notas = int.Parse(datos[3]);

        }
        public string ObtenerRegistro()
        {
            return String.Format("{0};{1};{2};{3}", this.DNI,this.Apellidos, this.Promedios, this.N_notas);
        } 
    }
}
