using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class Emprestimo
    {
        public Amigo amigo;
        public Revista revista;
        public string dataEmprestimo;
        public string dataDevolucao;
        public int id;
        public string status = "ABERTO";
    }
}
