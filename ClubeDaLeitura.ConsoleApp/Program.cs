using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            RepositorioRevista repositorioRevista = new RepositorioRevista();
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();

            TelaAmigo telaAmigo = new TelaAmigo();
            TelaCaixa telaCaixa = new TelaCaixa();
            TelaRevista telaRevista = new TelaRevista();
            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();

            Menus menus = new Menus();

            menus.revista = telaRevista;
            menus.caixa = telaCaixa;
            menus.emprestimo = telaEmprestimo;
            menus.amigo = telaAmigo;


            telaAmigo.repositorioAmigo = repositorioAmigo;

            telaCaixa.repositorioCaixa = repositorioCaixa;

            telaRevista.repositorioRevista = repositorioRevista;
            telaRevista.repositorioCaixa = repositorioCaixa;
            telaRevista.telacaixa = telaCaixa;

            telaEmprestimo.repositorioEmprestimo = repositorioEmprestimo;
            telaEmprestimo.repositorioAmigo = repositorioAmigo;
            telaEmprestimo.repositorioRevista = repositorioRevista;
            telaEmprestimo.telarevista = telaRevista;
            telaEmprestimo.telaAmigo = telaAmigo;

            menus.VisualizarMenu();
        }
    }
}
