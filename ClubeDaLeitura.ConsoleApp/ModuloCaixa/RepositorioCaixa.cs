using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class RepositorioCaixa
    {
        public int idCaixa = 1;
        public ArrayList Caixas;

        public Caixa PegarCaixaPorId(int id)
        {
            Caixa caixa = null;

            foreach (Caixa c in Caixas)
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
            Caixas.Add(caixa);
        }

        public void ExcluirCaixa(Caixa caixa)
        {
            Caixas.Remove(caixa);
        }

        public void IncrementarCaixa()
        {
            idCaixa++;
        }
    }
}
