using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.ValueObjects;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Services
{
    public static class MidiaFactory
    {
        public static Filme CriarFilme()
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine()!;

            Console.Write("Duração (minutos): ");
            var duracao = new Duracao(int.Parse(Console.ReadLine()!));

            Console.Write("Ano: ");
            var ano = int.Parse(Console.ReadLine()!);

            Console.Write("Gênero: ");
            var genero = Console.ReadLine()!;

            Console.Write("Diretor: ");
            var diretor = Console.ReadLine()!;

            Console.Write("Classificação Indicativa: ");
            var classificacao = Console.ReadLine()!;

            return new Filme(titulo, duracao, ano, genero, diretor, classificacao);
        }

        public static Serie CriarSerie()
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine()!;

            Console.Write("Duração por episódio (minutos): ");
            var duracao = new Duracao(int.Parse(Console.ReadLine()!));

            Console.Write("Ano: ");
            var ano = int.Parse(Console.ReadLine()!);

            Console.Write("Gênero: ");
            var genero = Console.ReadLine()!;

            Console.Write("Número de temporadas: ");
            var temporadas = int.Parse(Console.ReadLine()!);

            Console.Write("Episódios por temporada: ");
            var episodios = int.Parse(Console.ReadLine()!);

            return new Serie(titulo, duracao, ano, genero, temporadas, episodios);
        }

        public static Musica CriarMusica()
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine()!;

            Console.Write("Duração (minutos): ");
            var duracao = new Duracao(int.Parse(Console.ReadLine()!));

            Console.Write("Ano: ");
            var ano = int.Parse(Console.ReadLine()!);

            Console.Write("Gênero: ");
            var genero = Console.ReadLine()!;

            Console.Write("Artista: ");
            var artista = Console.ReadLine()!;

            Console.Write("Álbum: ");
            var album = Console.ReadLine()!;

            return new Musica(titulo, duracao, ano, genero, artista, album);
        }

        public static Podcast CriarPodcast()
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine()!;

            Console.Write("Duração (minutos): ");
            var duracao = new Duracao(int.Parse(Console.ReadLine()!));

            Console.Write("Ano: ");
            var ano = int.Parse(Console.ReadLine()!);

            Console.Write("Gênero: ");
            var genero = Console.ReadLine()!;

            Console.Write("Apresentador: ");
            var apresentador = Console.ReadLine()!;

            Console.Write("Convidados: ");
            var convidados = Console.ReadLine()!;

            return new Podcast(titulo, duracao, ano, genero, apresentador, convidados);
        }
    }
}
