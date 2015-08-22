using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public interface IOrganizadorRepositorio
    {
        void Adicionar(Organizador organizador);

        IEnumerable<Organizador> OrganizadoresAtivo();
        IEnumerable<Organizador> OrganizadoresAtivoAnoCorrente();
    }
}
