using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace TP10
{
    class GestorPromedio
    {
        string archivo_promedio = "C:\\Users\\Usuario\\Desktop\\promedio.txt";
        String archivo_aux = "C:\\Users\\Usuario\\Desktop\\promedioaux.txt";
        GestorNota gestornotas = new GestorNota();
        GestorAlumno gestoralumnos = new GestorAlumno();

        /*
    public string[] ObtenerPromedio( int i)
    {
        Nota[] dat_notas = notas.OrdenarNotas();
        Alumno[] dat_alumno = alumnos.OrdenarAlumnos();
        string[] dat_promedio = new string[0];
        string reg = "";
        Boolean parar = false;
            //for (int i = I; i < dat_alumno.Length; i++)
            while(i <dat_alumno.Length)
            {
                int contador = 0;
                int acumulador = 0;
                for (int j =0; j < dat_notas.Length; j++)
                {
                if (dat_notas[j].DNI == dat_alumno[i].DNI)
                {
                    // while que se detiene cuando el alumno ya no tiene mas notas
                    while (!parar)
                    {
                        contador++;
                        acumulador += dat_notas[j].Notas;
                        j++;
                        if (dat_notas[i].DNI != dat_alumno[j].DNI) parar = true;
                    }
                    reg = String.Format("{0},{1},{2},{3}", dat_alumno[i].DNI , dat_alumno[i].Apellido,(acumulador / contador), contador );

                    return ObtenerPromedio(i ++);
                    }
                }
            }
        return dat_promedio;
    } 
    public void Promediar()
    {
        string[] promedios = ObtenerPromedio(0);
        FileStream promedio = new FileStream(archivo_aux, FileMode.Create);
        StreamWriter EscritorArchivoAux = new StreamWriter(promedio);
        foreach (string item in promedios)
        {
            EscritorArchivoAux.WriteLine(item);
        }

        EscritorArchivoAux.Close();
        promedio.Close();
        File.Delete(archivo_promedio);
        File.Move(archivo_aux, archivo_promedio);
    } */
        public Promedio[] LeerPromedio()
        {
            Promedio[] lista = new Promedio[1];
            FileStream fs = new FileStream(archivo_promedio, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string linea = sr.ReadLine();
            int i = 0;

            while (linea != null)
            {
                lista[i] = new Promedio(linea);
                linea = sr.ReadLine();
                if (linea != null)
                {
                    //si hay mas lineas, amplio el vector.
                    Array.Resize(ref lista, lista.Length + 1);
                }
                i++;
            }
            fs.Close();
            sr.Close();

            return lista;
        }
        public Promedio Promedios()
        {
            FileStream fsaux = new FileStream(archivo_aux, FileMode.Create);
            StreamWriter swaux = new StreamWriter(fsaux);

            Alumno[] alumnos = gestoralumnos.OrdenarAlumnos();
            Nota[] notas = gestornotas.OrdenarNotas();
            Promedio p = new Promedio();
            Promedio promedio;
            int d = 0;
            for (int i = 0; i < alumnos.Length; i++)
            {
                int contador = 0;
                double acumulador = 0.0;
                for (int x = d; x < notas.Length; x++)
                {
                    if (notas[x].DNI == alumnos[i].DNI )
                    {
                        contador++;
                        acumulador += notas[x].Notas;
                    }
                    // Esto hace que termine la lista :D
                    if (notas[x].DNI > alumnos[i].DNI)
                    {
                        d = x;
                        x = notas.Length + 1;
                    }
                }
                if (contador != 0)
                {
                    p.DNI = alumnos[i].DNI;
                    p.Apellidos = alumnos[i].Apellido;
                    p.N_notas = contador;
                    p.Promedios = acumulador / contador;
                    promedio = new Promedio(p.DNI, p.Apellidos, p.Promedios, p.N_notas);
                    swaux.WriteLine(promedio.ObtenerRegistro());
                    GuardarPromedio(promedio);
                }
            }
            swaux.Close();
            fsaux.Close();
            File.Delete(archivo_promedio);
            File.Move(archivo_aux, archivo_promedio);
            return p;
        }
        public void GuardarPromedio(Promedio promedio)
        {
            FileStream fs = new FileStream(archivo_promedio, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(promedio.ObtenerRegistro());
            sw.Close();
        }
    }
}
