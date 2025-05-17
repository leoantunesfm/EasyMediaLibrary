using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Repositories;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Services
{
    public class BuscaAvancadaMidiaService
    {
        private readonly IMidiaRepository _midiaRepository;

        public BuscaAvancadaMidiaService(IMidiaRepository midiaRepository)
        {
            _midiaRepository = midiaRepository;
        }

        public IEnumerable<Midia> Buscar(string titulo, int? ano = null, string genero = null)
        {
            var resultados = _midiaRepository.BuscarPorTitulo(titulo);

            if (ano.HasValue)
                resultados = resultados.Where(m => m.Ano == ano.Value);

            if (!string.IsNullOrEmpty(genero))
                resultados = resultados.Where(m => m.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase));

            return resultados;
        }
    }
}
