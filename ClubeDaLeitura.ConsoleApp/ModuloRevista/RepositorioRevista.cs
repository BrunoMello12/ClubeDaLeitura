using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista : Repositorio
    {
        public int idRevista = 1;

        public void AdicionarRevista(Revista revista)
        {
            listaRegistro.Add(revista);
        }

        public void ExcluirRevista(Revista revista)
        {
            listaRegistro.Remove(revista);
        }

        public Revista PegarRevistaPorId(int id)
        {
            Revista revista = null;

            foreach (Revista r in listaRegistro)
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
