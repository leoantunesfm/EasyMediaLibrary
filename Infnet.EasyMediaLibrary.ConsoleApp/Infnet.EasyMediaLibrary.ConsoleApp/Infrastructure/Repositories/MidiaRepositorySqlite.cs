using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Repositories;
using Infnet.EasyMediaLibrary.ConsoleApp.Infrastructure.Data;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Infrastructure.Repositories
{
    public class MidiaRepositorySqlite : IMidiaRepository
    {
        private readonly MediaLibraryDbContext _context;

        public MidiaRepositorySqlite(MediaLibraryDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated(); // Cria o banco se não existir
        }

        public void Adicionar(Midia midia)
        {
            _context.Midias.Add(midia);
            _context.SaveChanges();
        }

        public Midia ObterPorId(Guid id)
        {
            return _context.Midias.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Midia> BuscarPorTitulo(string titulo)
        {
            return _context.Midias
                .Where(m => m.Titulo.Contains(titulo))
                .ToList();
        }

        public IEnumerable<Midia> ListarTodas()
        {
            return _context.Midias.ToList();
        }
    }
}
