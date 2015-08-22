using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Core
{
    public class NomeCompleto
    {
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }

        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            SobreNome = sobrenome;
        }

        public string EscreverNome()
        {
            return $"{Nome} {SobreNome}";
        }
    }
}
