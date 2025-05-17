using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Repositories;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Services;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Application
{
    public class MediaLibraryApp
    {
        private readonly IMidiaRepository _midiaRepository;
        private readonly BuscaAvancadaMidiaService _buscaService;

        public MediaLibraryApp(IMidiaRepository midiaRepository, BuscaAvancadaMidiaService buscaService)
        {
            _midiaRepository = midiaRepository;
            _buscaService = buscaService;
        }

        public void Run()
        {
            while (true)
            {
                ExibirMenuPrincipal();
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarMidia();
                        break;
                    case "2":
                        ListarMidias();
                        break;
                    case "3":
                        BuscarMidias();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private void ExibirMenuPrincipal()
        {
            Console.WriteLine("\n=== EasyMediaLibrary ===");
            Console.WriteLine("1. Adicionar Mídia");
            Console.WriteLine("2. Listar Todas as Mídias");
            Console.WriteLine("3. Buscar Mídias");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
        }

        private void AdicionarMidia()
        {
            Console.WriteLine("\nSelecione o tipo de mídia:");
            Console.WriteLine("1. Filme");
            Console.WriteLine("2. Série");
            Console.WriteLine("3. Música");
            Console.WriteLine("4. Podcast");
            Console.Write("Opção: ");

            var tipo = Console.ReadLine();

            try
            {
                Midia novaMidia = tipo switch
                {
                    "1" => MidiaFactory.CriarFilme(),
                    "2" => MidiaFactory.CriarSerie(),
                    "3" => MidiaFactory.CriarMusica(),
                    "4" => MidiaFactory.CriarPodcast(),
                    _ => throw new ArgumentException("Tipo inválido")
                };

                _midiaRepository.Adicionar(novaMidia);
                Console.WriteLine("Mídia adicionada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        private void ListarMidias()
        {
            var midias = _midiaRepository.ListarTodas();
            foreach (var midia in midias)
            {
                switch (midia)
                {
                    case Filme filme:
                        Console.WriteLine($"[Filme] {filme.Titulo} ({filme.Ano}) - Dirigido por {filme.Diretor}");
                        break;
                    case Serie serie:
                        Console.WriteLine($"[Série] {serie.Titulo} ({serie.Ano}) - {serie.NumeroTemporadas} temporadas");
                        break;
                    case Musica musica:
                        Console.WriteLine($"[Música] {musica.Titulo} - {musica.Artista} ({musica.Album})");
                        break;
                    case Podcast podcast:
                        Console.WriteLine($"[Podcast] {podcast.Titulo} - Apresentado por {podcast.Apresentador}");
                        break;
                    default:
                        Console.WriteLine($"[Mídia] {midia.Titulo}");
                        break;
                }
            }
        }

        private void BuscarMidias()
        {
            Console.Write("Título (opcional): ");
            var titulo = Console.ReadLine();

            Console.Write("Ano (opcional): ");
            var anoInput = Console.ReadLine();
            int? ano = string.IsNullOrEmpty(anoInput) ? null : int.Parse(anoInput);

            Console.Write("Gênero (opcional): ");
            var genero = Console.ReadLine();

            var resultados = _buscaService.Buscar(titulo, ano, genero);

            foreach (var midia in resultados)
            {
                Console.WriteLine($"{midia.Titulo} ({midia.Ano}) - {midia.Genero}");
            }
        }
    }
}
