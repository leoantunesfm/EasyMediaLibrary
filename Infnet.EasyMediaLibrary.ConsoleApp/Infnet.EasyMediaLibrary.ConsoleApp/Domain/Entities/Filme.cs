using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.ValueObjects;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities
{
    public class Filme : Midia
    {
        public string Diretor { get; private set; }
        public string ClassificacaoIndicativa { get; private set; }

        private Filme() { }

        public Filme(
            string titulo,
            Duracao duracao,
            int ano,
            string genero,
            string diretor,
            string classificacaoIndicativa)
            : base(titulo, duracao, ano, genero)
        {
            Diretor = diretor;
            ClassificacaoIndicativa = classificacaoIndicativa;
        }

        public override void Reproduzir()
        {
            Console.WriteLine($"Reproduzindo filme: {Titulo} ({Ano})");
        }
    }
}
