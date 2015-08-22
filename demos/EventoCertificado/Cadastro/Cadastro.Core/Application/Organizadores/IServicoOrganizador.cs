using Cadastro.Core.Domain.Model.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Application.Organizadores
{
    public interface IServicoOrganizador
    {
        void CadastrarNovoOrganizador(Organizador organizador);
    }
}
