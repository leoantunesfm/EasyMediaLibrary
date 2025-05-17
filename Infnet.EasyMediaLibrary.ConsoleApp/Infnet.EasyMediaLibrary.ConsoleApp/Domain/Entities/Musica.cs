using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.ValueObjects;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities
{
    public class Musica : Midia
    {
        public string Artista { get; private set; }
        public string Album { get; private set; }

        private Musica() { }

        public Musica(
            string titulo,
            Duracao duracao,
            int ano,
            string genero,
            string artista,
            string album)
            : base(titulo, duracao, ano, genero)
        {
            Artista = artista;
            Album = album;
        }

        public override void Reproduzir()
        {
            Console.WriteLine($"Reproduzindo música: {Artista} - {Titulo}");
        }
    }
}
