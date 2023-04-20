using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class TelaEmprestimo
    {
        public TelaAmigo telaAmigo;
        public TelaRevista telarevista;
        public RepositorioAmigo repositorioAmigo;
        public RepositorioRevista repositorioRevista;
        public RepositorioEmprestimo repositorioEmprestimo;

        public void AdicionarEmprestimo()
        {
            Emprestimo emprestimo = new Emprestimo();

            Console.WriteLine("-----------------------AMIGOS------------------------");
            telaAmigo.VisualizarAmigos();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("----------------------REVISTAS-----------------------");
            telarevista.VisualizarRevistas();
            Console.WriteLine("-----------------------------------------------------");
            if (repositorioAmigo.listaAmigo.Count == 0 || repositorioRevista.listaRevista.Count == 0)
                return;

            Console.WriteLine("Informe o id do amigo que pegou a revista: ");
            int idAmigoSelecionado = int.Parse(Console.ReadLine());
            emprestimo.amigo = repositorioAmigo.PegarAmigoPorId(idAmigoSelecionado);

            if (emprestimo.amigo == null)
            {
                ApresentarMensagem("ID inválido, tente novamente!", ConsoleColor.Red);
                return;
            }

            Console.WriteLine("Informe o id da revista emprestada: ");
            int idRevistaSelecionada = int.Parse(Console.ReadLine());
            emprestimo.revista = repositorioRevista.PegarRevistaPorId(idRevistaSelecionada);

            if (emprestimo.revista == null)
            {
                ApresentarMensagem("ID inválido, tente novamente!", ConsoleColor.Red);
                return;
            }

            Console.WriteLine("Informe a data do emprestimo: ");
            emprestimo.dataEmprestimo = Console.ReadLine();
            Console.WriteLine("Informe a data de devolução: ");
            emprestimo.dataDevolucao = Console.ReadLine();
            emprestimo.id = repositorioEmprestimo.idEmprestimo;

            repositorioEmprestimo.AdicionarEmprestimo(emprestimo);
            ApresentarMensagem("Emprestimo adicionado com sucesso!", ConsoleColor.Green);
            repositorioEmprestimo.incrementarId();
        }

        public void VisualizarEmprestimo()
        {
            if (repositorioEmprestimo.listaEmprestimo.Count == 0)
            {
                ApresentarMensagem("Não tem emprestimos adicionados", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0,-10} | {1,-20} | {2,-10} | {3,-20} | {4,-20} | {5,-10}", "ID", "Nome do Amigo", "Revista",
                    "Data de abertura", "Data de devolução", "Status");
                foreach (Emprestimo emprestimo in repositorioEmprestimo.listaEmprestimo)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-10} | {3,-20} | {4,-20} | {5,-10}", emprestimo.id, emprestimo.amigo.Nome, emprestimo.revista.tipoColecao,
                        emprestimo.dataEmprestimo, emprestimo.dataDevolucao, emprestimo.status);
                }
            }
            Console.ResetColor();
        }

        public void AlterarStatus()
        {
            VisualizarEmprestimo();
            if (repositorioEmprestimo.listaEmprestimo.Count == 0)
                return;
            Console.WriteLine();
            Console.WriteLine("Informe o id do emprestimo que deseja alterar o status: ");
            int idSelecionado = int.Parse(Console.ReadLine());

            Emprestimo emprestimo = repositorioEmprestimo.PegarEmprestimoPorId(idSelecionado);
            repositorioEmprestimo.FecharStatus(emprestimo);
            ApresentarMensagem("Status alterado com sucesso!", ConsoleColor.Green);
        }

        private void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.WriteLine();
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
