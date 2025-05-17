using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.ValueObjects;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities
{
    public class Serie : Midia
    {
        public int NumeroTemporadas { get; private set; }
        public int EpisodiosPorTemporada { get; private set; }

        private Serie() { } 

        public Serie(
            string titulo,
            Duracao duracao,
            int ano,
            string genero,
            int numeroTemporadas,
            int episodiosPorTemporada)
            : base(titulo, duracao, ano, genero)
        {
            NumeroTemporadas = numeroTemporadas;
            EpisodiosPorTemporada = episodiosPorTemporada;
        }

        public override void Reproduzir()
        {
            Console.WriteLine($"Reproduzindo série: {Titulo} - Temporada 1, Episódio 1");
        }
    }
}
