using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application.Organizadores
{
    public class SerivicosOrganizador : IServicoOrganizador
    {
        private readonly IOrganizadorRepositorio _repositorio;

        public SerivicosOrganizador(IOrganizadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CadastrarNovoOrganizador(Organizador organizador)
        {
            if (organizador.IsValid())
            {
                _repositorio.Adicionar(organizador);
            }
        }
    }
}
