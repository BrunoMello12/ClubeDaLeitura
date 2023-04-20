using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class RepositorioAmigo : Repositorio
    {
        public void AdicionarAmigo(Amigo amigo)
        {
            listaRegistro.Add(amigo);
        }

        public Amigo PegarAmigoPorId(int id)
        {
            Amigo amigo = null;

            foreach (Amigo a in listaRegistro)
            {
                if (a.id == id)
                {
                    amigo = a;
                    break;
                }
            }
            return amigo;
        }

        public void ExcluirAmigo(Amigo amigo)
        {
            listaRegistro.Remove(amigo);
        }

    }
}
