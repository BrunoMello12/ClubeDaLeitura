using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class RepositorioCaixa : Repositorio
    {
        public int idCaixa = 1;

        public Caixa PegarCaixaPorId(int id)
        {
            Caixa caixa = null;

            foreach (Caixa c in listaRegistro)
            {
                if (c.id == id)
                {
                    caixa = c;
                    break;
                }
            }
            return caixa;
        }

        public void AdicionarCaixa(Caixa caixa)
        {
            listaRegistro.Add(caixa);
        }

        public void ExcluirCaixa(Caixa caixa)
        {
            listaRegistro.Remove(caixa);
        }

        public void IncrementarCaixa()
        {
            idCaixa++;
        }
    }
}
