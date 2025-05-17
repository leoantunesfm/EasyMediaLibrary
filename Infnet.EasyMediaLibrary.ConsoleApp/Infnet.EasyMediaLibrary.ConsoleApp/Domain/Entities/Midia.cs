using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.ValueObjects;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities
{
    public abstract class Midia
    {
        public Guid Id { get; protected set; }
        public string Titulo { get; protected set; }
        public Duracao Duracao { get; protected set; }
        public int Ano { get; protected set; }
        public string Genero { get; protected set; }

        protected Midia() { }

        protected Midia(string titulo, Duracao duracao, int ano, string genero)
        {
            Titulo = titulo;
            Duracao = duracao;
            Ano = ano;
            Genero = genero;
        }

        public abstract void Reproduzir();
    }
}
