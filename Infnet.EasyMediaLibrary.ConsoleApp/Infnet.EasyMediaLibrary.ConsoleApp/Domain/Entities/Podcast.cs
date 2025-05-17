using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.ValueObjects;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities
{
    public class Podcast : Midia
    {
        public string Apresentador { get; private set; }
        public string Convidados { get; private set; }

        private Podcast() { }

        public Podcast(
            string titulo,
            Duracao duracao,
            int ano,
            string genero,
            string apresentador,
            string convidados)
            : base(titulo, duracao, ano, genero)
        {
            Apresentador = apresentador;
            Convidados = convidados;
        }

        public override void Reproduzir()
        {
            Console.WriteLine($"Reproduzindo podcast: {Titulo} com {Apresentador}");
        }
    }
}
