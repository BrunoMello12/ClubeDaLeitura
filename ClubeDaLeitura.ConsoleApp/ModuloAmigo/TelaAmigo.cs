using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class TelaAmigo
    {
        public RepositorioAmigo repositorioAmigo;

        public void AdicionarAmigo()
        {
            Console.Clear();
            Amigo amigo = new Amigo();
            Console.WriteLine("Informe o nome do amigo: ");
            amigo.Nome = Console.ReadLine();
            Console.WriteLine("Informe o nome do responsável: ");
            amigo.nomeResponsavel = Console.ReadLine();
            Console.WriteLine("Informe o telefone: ");
            amigo.Telefone = Console.ReadLine();
            Console.WriteLine("Informe o endereço: ");
            amigo.Endereco = Console.ReadLine();
            amigo.id = repositorioAmigo.idAmigo;

            repositorioAmigo.AdicionarAmigo(amigo);
            ApresentarMensagem("Amigo adicionado com sucesso!", ConsoleColor.Green);
            repositorioAmigo.IncrementarAmigo();
        }

        public void VisualizarAmigos()
        {
            if (repositorioAmigo.listaAmigo.Count == 0)
            {
                ApresentarMensagem("Não tem amigos adicionados", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0,-10} | {1,-20} | {2,-30} | {3,-20} | {4,-30}", "ID", "Nome do Amigo", "Nome do Responsável",
                    "Telefone", "Endereço");
                foreach (Amigo amigo in repositorioAmigo.listaAmigo)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-30} | {3,-20} | {4,-30}", amigo.id, amigo.Nome, amigo.nomeResponsavel,
                        amigo.Telefone, amigo.Endereco);
                }
            }
            Console.ResetColor();
        }

        public void EditarAmigo()
        {
            VisualizarAmigos();
            if (repositorioAmigo.listaAmigo.Count == 0)
                return;
            Console.WriteLine("Informe o id do amigo que deseja editar: ");
            int idSelecionado = int.Parse(Console.ReadLine());
            Amigo amigo = repositorioAmigo.PegarAmigoPorId(idSelecionado);

            if (amigo == null)
                ApresentarMensagem("ID inválido, tente novamente...", ConsoleColor.Red);
            else
            {
                Console.WriteLine("Informe o nome do amigo: ");
                amigo.Nome = Console.ReadLine();
                Console.WriteLine("Informe o nome do responsável: ");
                amigo.nomeResponsavel = Console.ReadLine();
                Console.WriteLine("Informe o telefone: ");
                amigo.Telefone = Console.ReadLine();
                Console.WriteLine("Informe o endereço: ");
                amigo.Endereco = Console.ReadLine();

                ApresentarMensagem("Amigo editado com sucesso!", ConsoleColor.Green);
            }
        }

        public void ExcluirAmigo()
        {
            VisualizarAmigos();
            if (repositorioAmigo.listaAmigo.Count == 0)
                return;

            Console.WriteLine("Informe o id do amigo que deseja excluir: ");
            int idSelecionado = int.Parse(Console.ReadLine());
            Amigo amigo = repositorioAmigo.PegarAmigoPorId(idSelecionado);
            if (amigo == null)
                ApresentarMensagem("ID inválido, tente novamente...", ConsoleColor.Red);
            else
            {
                repositorioAmigo.ExcluirAmigo(amigo);
                ApresentarMensagem("Amigo excluido com sucesso!", ConsoleColor.Green);
            }
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
