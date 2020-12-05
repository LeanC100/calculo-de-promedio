using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP10
{
    class GestorNota
    {
        string archivo_nota = "C:\\Users\\Usuario\\Desktop\\Nota.txt";
        String archivo_aux = "C:\\Users\\Usuario\\Desktop\\notaaux.txt";
        public Nota[] LeerNotas()
        {
            Nota[] lista = new Nota[1];
            FileStream fs = new FileStream(archivo_nota, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string linea = sr.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new Nota(linea);
                linea = sr.ReadLine();
                if (linea != null)
                {
                    //si hay mas lineas, amplio el vector.
                    Array.Resize(ref lista, lista.Length + 1);
                }
                i++;
            }
            sr.Close();
            return lista;
        }
        /*
        public List<Nota> OrdenarNotas()
        {
            List<Nota> lista = LeerNotas().ToList();

            lista.Sort();
            return lista;
        } */

        public Nota[] OrdenarNotas()
        {
            Nota[] notas = LeerNotas();

            for (int i = 0; i < notas.Length; i++)
            {
                var aux = notas[i];
                for (int j = 0; j < notas.Length - i - 1; j++)
                {

                    if (notas[j].DNI > notas[j + 1].DNI)
                    {
                        aux = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = aux;
                    }
                }
            }
            return notas;
        }
        public Nota[] SubirOrdenar()
        {
            FileStream alumnoaux = new FileStream(archivo_aux, FileMode.Create);
            StreamWriter EscritorArchivoAux = new StreamWriter(alumnoaux);
            Nota[] nota = OrdenarNotas();

            foreach (var item in nota)
            {
                EscritorArchivoAux.WriteLine(item.ObtenerRegistro());
            }

            EscritorArchivoAux.Close();
            alumnoaux.Close();
            File.Delete(archivo_nota);
            File.Move(archivo_aux, archivo_nota);

            return nota;
        }
        public void GuardarNota(Nota nota)
        {
            FileStream fs = new FileStream(archivo_nota, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(nota.ObtenerRegistro());
            sw.Close();
        }
    }
}
