using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Repositories
{
    public interface IMidiaRepository
    {
        void Adicionar(Midia midia);
        Midia ObterPorId(Guid id);
        IEnumerable<Midia> BuscarPorTitulo(string titulo);
        IEnumerable<Midia> ListarTodas();
    }
}
