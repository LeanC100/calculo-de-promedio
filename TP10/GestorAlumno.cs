using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Messaging;

namespace TP10
{
    class GestorAlumno
    {
        string archivo_alumnos = "C:\\Users\\Usuario\\Desktop\\Alumnos.txt";
        String archivo_aux = "C:\\Users\\Usuario\\Desktop\\alumnoaux.txt";

        public Alumno[] LeerAlumno()
        {
            Alumno[] lista = new Alumno[1];
            FileStream fs = new FileStream(archivo_alumnos, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string linea = sr.ReadLine();
            int i = 0;

            while (linea != null)
            {
                lista[i] = new Alumno(linea);
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
        /*
        public List<Alumno> OrdenarAlumnos()
        {
            Alumno[] dni = LeerAlumno();
            List<Alumno> lista = LeerAlumno().ToList();  
            lista.Sort() ;
            return lista;
        } */

        public Alumno[] OrdenarAlumnos()
        {
            
            Alumno[] alumnos = LeerAlumno();

            for (int i = 0; i < alumnos.Length; i++)
            {
                var aux = alumnos[i];
                for (int j = 0; j < alumnos.Length - i - 1; j++)
                {

                    if (alumnos[j].DNI > alumnos[j+1].DNI)
                    {
                        aux = alumnos[j];
                        alumnos[j] = alumnos[j + 1];
                        alumnos[j + 1] = aux;
                    }
                }
            }
            return alumnos;
        }
        public Alumno[] SubirOrdenar()
        {
            FileStream alumnoaux = new FileStream(archivo_aux, FileMode.Create);
            StreamWriter EscritorArchivoAux = new StreamWriter(alumnoaux);
            Alumno[] alumno = OrdenarAlumnos();

            foreach (var item in alumno)
            {
                EscritorArchivoAux.WriteLine(item.ObtenerRegistro());
            }

            EscritorArchivoAux.Close();
            alumnoaux.Close();
            File.Delete(archivo_alumnos);
            File.Move(archivo_aux, archivo_alumnos);

            return alumno;
        }
            public void GuardarALumno(Alumno alumno)
        {
            FileStream fs = new FileStream(archivo_alumnos, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(alumno.ObtenerRegistro());
            sw.Close();
        }
    }
}
