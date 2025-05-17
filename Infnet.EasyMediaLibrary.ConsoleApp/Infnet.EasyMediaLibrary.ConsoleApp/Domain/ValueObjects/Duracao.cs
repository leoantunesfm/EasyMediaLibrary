using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Domain.ValueObjects
{
    public sealed class Duracao
    {
        public int Minutos { get; }

        private Duracao() { }

        public Duracao(int minutos)
        {
            if (minutos <= 0)
                throw new ArgumentException("Duração deve ser maior que zero.");

            Minutos = minutos;
        }
    }
}
