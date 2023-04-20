using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class TelaRevista : Tela
    {
        public TelaCaixa telacaixa;
        public RepositorioCaixa repositorioCaixa;
        public RepositorioRevista repositorioRevista;

        public void AdicionarRevistaNaCaixa()
        {
            if (repositorioCaixa.listaRegistro.Count == 0)
            {
                ApresentarMensagem("Não tem Caixas adicionadas", ConsoleColor.DarkYellow);
                return;
            }
            else
            {
                Revista revista = new Revista();
                Console.Clear();
                Console.WriteLine("-------------------CAIXAS-----------------------------------");
                telacaixa.VisualizarCaixas();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Informe o tipo da coleção: ");
                revista.tipoColecao = Console.ReadLine();
                Console.WriteLine("Informe o numero da edição: ");
                revista.numEdicao = Console.ReadLine();
                Console.WriteLine("Informe o ano da resvista: ");
                revista.anoRevista = Console.ReadLine();
                Console.WriteLine("Informe o id da caixa que quer adicionar a revista: ");
                int idSelecionado = int.Parse(Console.ReadLine());
                revista.caixa = repositorioCaixa.PegarCaixaPorId(idSelecionado);
                if (revista.caixa == null)
                {
                    ApresentarMensagem("ID inválido, tente novamente...", ConsoleColor.Red);
                    return;
                }
                revista.id = repositorioRevista.idRevista;

                repositorioRevista.AdicionarRevista(revista);


                ApresentarMensagem("Revista Adicionada com sucesso!", ConsoleColor.Green);
                repositorioRevista.IncrementarRevista();
            }
        }

        public void VisualizarRevistas()
        {
            if (repositorioRevista.listaRegistro.Count == 0)
            {
                ApresentarMensagem("Não tem Revistas adicionadas", ConsoleColor.DarkYellow);
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", "ID", "Tipo Coleção", "Número da Edição",
                    "Ano da Revista", "Etiqueta");
                foreach (Revista revista in repositorioRevista.listaRegistro)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", revista.id, revista.tipoColecao,
                        revista.numEdicao, revista.anoRevista, revista.caixa.Etiqueta);
                }
                Console.ResetColor();
            }
        }

        public void EditarRevista()
        {
            Console.WriteLine("----------------------------------REVISTAS--------------------------------------");
            VisualizarRevistas();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-------------------CAIXAS-----------------------------------");
            telacaixa.VisualizarCaixas();
            Console.WriteLine("------------------------------------------------------------");

            if (repositorioCaixa.listaRegistro.Count == 0 || repositorioRevista.listaRegistro.Count == 0)
                return;

            Console.WriteLine("Informe o id da revista que deseja editar: ");
            int idEdicao = int.Parse(Console.ReadLine());
            Revista revista = repositorioRevista.PegarRevistaPorId(idEdicao);

            if (revista == null)
            {
                ApresentarMensagem("ID inválido, tente novamente...", ConsoleColor.Red);
            }
            else
            {
                Console.WriteLine("Informe o tipo da coleção: ");
                revista.tipoColecao = Console.ReadLine();
                Console.WriteLine("Informe o numero da edição: ");
                revista.numEdicao = Console.ReadLine();
                Console.WriteLine("Informe o ano da resvista: ");
                revista.anoRevista = Console.ReadLine();
                Console.WriteLine("Informe o id da caixa que quer adicionar a revista: ");
                int idSelecionado = int.Parse(Console.ReadLine());
                revista.caixa = repositorioCaixa.PegarCaixaPorId(idSelecionado);

                ApresentarMensagem("Revista editada com sucesso!", ConsoleColor.Green);

            }
        }

        public void ExcluirRevista()
        {
            VisualizarRevistas();
            if (repositorioRevista.listaRegistro.Count == 0)
                return;

            Console.WriteLine();
            Console.WriteLine("Informe o id da revista que deseja excluir: ");
            int idSelecionado = int.Parse(Console.ReadLine());
            Revista revista = repositorioRevista.PegarRevistaPorId(idSelecionado);
            if (revista == null)
            {
                ApresentarMensagem("ID inválido, tente novamente...", ConsoleColor.Red);
                return;
            }
            else
            {
                repositorioRevista.ExcluirRevista(revista);
                ApresentarMensagem("Revista removida com sucesso!", ConsoleColor.Green);
            }

        }

    }
}
