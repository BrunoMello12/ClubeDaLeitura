using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class Emprestimo : Entidade
    {
        public Amigo amigo;
        public Revista revista;
        public string dataEmprestimo;
        public string dataDevolucao;
        public string status = "ABERTO";
    }
}
