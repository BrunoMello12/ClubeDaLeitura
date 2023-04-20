using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class RepositorioEmprestimo : Repositorio
    {
        public int idEmprestimo = 1;

        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            listaRegistro.Add(emprestimo);
        }

        public Emprestimo PegarEmprestimoPorId(int id)
        {
            Emprestimo emprestimo = null;

            foreach (Emprestimo e in listaRegistro)
            {
                if (e.id == id)
                {
                    emprestimo = e;
                }
            }
            return emprestimo;
        }

        public void FecharStatus(Emprestimo emprestimo)
        {
            emprestimo.status = "FECHADO";
        }

        public void incrementarId()
        {
            idEmprestimo++;
        }
    }
}
