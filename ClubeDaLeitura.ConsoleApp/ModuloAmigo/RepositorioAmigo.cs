using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class RepositorioAmigo
    {
        public int idAmigo = 1;
        public ArrayList listaAmigo;

        public void AdicionarAmigo(Amigo amigo)
        {
            listaAmigo.Add(amigo);
        }

        public Amigo PegarAmigoPorId(int id)
        {
            Amigo amigo = null;

            foreach (Amigo a in listaAmigo)
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
            listaAmigo.Remove(amigo);
        }

        public void IncrementarAmigo()
        {
            idAmigo++;
        }
    }
}
