using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class Revista : Entidade
    {
        public string tipoColecao;
        public string numEdicao;
        public string anoRevista;
        public Caixa caixa;
    }
}
