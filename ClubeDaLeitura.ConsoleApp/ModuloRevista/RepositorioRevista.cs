using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista
    {
        public int idRevista = 1;
        public ArrayList listaRevista;

        public void AdicionarRevista(Revista revista)
        {
            listaRevista.Add(revista);
        }

        public void ExcluirRevista(Revista revista)
        {
            listaRevista.Remove(revista);
        }

        public Revista PegarRevistaPorId(int id)
        {
            Revista revista = null;

            foreach (Revista r in listaRevista)
            {
                if (r.id == id)
                {
                    revista = r;
                }
            }
            return revista;
        }

        public void IncrementarRevista()
        {
            idRevista++;
        }
    }
}
