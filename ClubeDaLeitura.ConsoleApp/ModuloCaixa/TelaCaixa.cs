using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class TelaCaixa : Tela
    {
        public RepositorioCaixa repositorioCaixa;

        public void AdicionarCaixa()
        {
            Console.Clear();
            Caixa caixa = new Caixa();
            Console.WriteLine("Informe a cor da caixa: ");
            caixa.Cor = Console.ReadLine();
            Console.WriteLine("Informe a etiqueta da caixa: ");
            caixa.Etiqueta = Console.ReadLine();

            caixa.id = repositorioCaixa.idCaixa;

            repositorioCaixa.AdicionarCaixa(caixa);
            ApresentarMensagem("Caixa adicionada com sucesso!", ConsoleColor.Green);
            repositorioCaixa.IncrementarCaixa();
        }

        public void VisualizarCaixas()
        {
            if (repositorioCaixa.listaRegistro.Count == 0)
            {
                ApresentarMensagem("Não tem caixas adicionadas", ConsoleColor.DarkYellow);
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0,-20} | {1,-20} | {2,-20}", "ID", "Cor", "Etiqueta");
                foreach (Caixa caixa in repositorioCaixa.listaRegistro)
                {
                    Console.WriteLine("{0,-20} | {1,-20} | {2,-20}", caixa.id, caixa.Cor, caixa.Etiqueta);

                }
            }
            Console.ResetColor();
        }

        public void EditarCaixa()
        {
            VisualizarCaixas();

            if (repositorioCaixa.listaRegistro.Count == 0)
                return;

            Console.WriteLine("Informe o id da caixa que deseja editar: ");
            int idSelecionado = int.Parse(Console.ReadLine());
            Caixa caixa = repositorioCaixa.PegarCaixaPorId(idSelecionado);
            if (caixa == null)
                ApresentarMensagem("ID inválido, tente novamente...", ConsoleColor.Red);
            else
            {
                Console.WriteLine("Informe a cor da caixa: ");
                caixa.Cor = Console.ReadLine();
                Console.WriteLine("Informe a etiqueta da caixa: ");
                caixa.Etiqueta = Console.ReadLine();
                ApresentarMensagem("Caixa editada com sucesso!", ConsoleColor.Green);
            }
        }

        public void ExcluirCaixa()
        {
            VisualizarCaixas();

            if (repositorioCaixa.listaRegistro.Count == 0)
                return;

            Console.WriteLine("Informe o id do equipamento que deseja excluir: ");
            int idSelecionado = int.Parse(Console.ReadLine());
            Caixa caixa = repositorioCaixa.PegarCaixaPorId(idSelecionado);
            if (caixa == null)
                ApresentarMensagem("ID inválido, tente novamente...", ConsoleColor.Red);
            else
            {
                repositorioCaixa.ExcluirCaixa(caixa);
                ApresentarMensagem("Caixa removida com sucesso!", ConsoleColor.Green);
            }
        }

    }
}
