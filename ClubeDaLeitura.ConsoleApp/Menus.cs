using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Menus
    {
        public TelaCaixa caixa;
        public TelaAmigo amigo;
        public TelaRevista revista;
        public TelaEmprestimo emprestimo;


        public void VisualizarMenu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("************************************");
                Console.WriteLine("**********CLUBE DA LEITURA**********");
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para gerenciar Caixas");
                Console.WriteLine("Digite 2 para gerenciar Amigos");
                Console.WriteLine("Digite 3 para gerenciar Revistas");
                Console.WriteLine("Digite 4 para gerenciar Empréstimos");
                Console.WriteLine("Digite S para sair");

                string opcaoMenuPrincipal = Console.ReadLine();

                switch (opcaoMenuPrincipal)
                {
                    case "1": VisualizarMenuCaixas(); break;
                    case "2": VisualizarMenuAmigos(); break;
                    case "3": VisualizarMenuRevistas(); break;
                    case "4": VisualizarMenuEmprestimos(); break;
                }

                if (opcaoMenuPrincipal == "s" || opcaoMenuPrincipal == "S")
                    Console.WriteLine("Saindo..."); break;
            }
            
        }

        public void VisualizarMenuCaixas()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para adicionar uma caixa");
                Console.WriteLine("Digite 2 para visualizar as caixas");
                Console.WriteLine("Digite 3 para editar uma caixa");
                Console.WriteLine("Digite 4 para remover uma caixa");
                Console.WriteLine("Digite V para voltar");

                string opcaoMenuCaixas = Console.ReadLine();

                switch (opcaoMenuCaixas)
                {
                    case "1": caixa.AdicionarCaixa(); break;
                    case "2": caixa.VisualizarCaixas(); Console.ReadLine(); break;
                    case "3": caixa.EditarCaixa(); break;
                    case "4": caixa.ExcluirCaixa(); break;
                }

                Voltar(opcaoMenuCaixas); 
            }
           
        }

        public string VisualizarMenuAmigos()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para adicionar um amigo");
                Console.WriteLine("Digite 2 para visualizar os amigos");
                Console.WriteLine("Digite 3 para editar um amigo");
                Console.WriteLine("Digite 4 para remover um amigo");
                Console.WriteLine("Digite V para voltar");

                string opcaoMenuAmigos = Console.ReadLine();

                switch (opcaoMenuAmigos)
                {
                    case "1": amigo.AdicionarAmigo(); break;
                    case "2": amigo.VisualizarAmigos(); Console.ReadLine(); break;
                    case "3": amigo.EditarAmigo(); break;
                    case "4": amigo.ExcluirAmigo(); break;
                }

                Voltar(opcaoMenuAmigos);
            }
            
        }

        public string VisualizarMenuRevistas()
        {
            while (true)
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Digite 1 para adicionar uma revista");
                Console.WriteLine("Digite 2 para visualizar as revistas");
                Console.WriteLine("Digite 3 para editar uma revista");
                Console.WriteLine("Digite 4 para remover uma revista");
                Console.WriteLine("Digite V para voltar");

                string opcaoMenuRevistas = Console.ReadLine();

                switch (opcaoMenuRevistas)
                {
                    case "1": revista.AdicionarRevistaNaCaixa(); break;
                    case "2": revista.VisualizarRevistas(); Console.ReadLine(); break;
                    case "3": revista.EditarRevista(); break;
                    case "4": revista.ExcluirRevista(); break;
                }

                Voltar(opcaoMenuRevistas);
            }
           
        }

        public string VisualizarMenuEmprestimos()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para adicionar um emprestimo");
                Console.WriteLine("Digite 2 para visualizar os emprestimos");
                Console.WriteLine("Digite 3 para alterar status");
                Console.WriteLine("Digite V para voltar");

                string opcaoMenuEmprestimos = Console.ReadLine();

                switch (opcaoMenuEmprestimos)
                {
                    case "1": emprestimo.AdicionarEmprestimo(); break;
                    case "2": emprestimo.VisualizarEmprestimo(); Console.ReadLine(); break;
                    case "3": emprestimo.AlterarStatus(); break;
                }

                Voltar(opcaoMenuEmprestimos);
            }

        }

        private void Voltar(string opcao)
        {
            if (opcao == "v" || opcao == "V")
            {
                VisualizarMenu();
            }
        }
    }
}
