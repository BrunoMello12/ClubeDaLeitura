using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Compartilhado
{
    public class Repositorio
    {
        public ArrayList listaRegistro = new ArrayList();
        public int ContadorId = 1;

        public void IncrementarId()
        {
            ContadorId++;
        }
    }
}
