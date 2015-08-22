using Cadastro.Core.Domain.Model.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data
{
    public class OrganizadorRepositorio : IOrganizadorRepositorio
    {
        public void Adicionar(Organizador organizador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organizador> OrganizadoresAtivo()
        {
            var q = new List<Organizador>().AsQueryable();

            return q.Where(OrganizadorScope.TodosAtivos);
        }

        public IEnumerable<Organizador> OrganizadoresAtivoAnoCorrente()
        {
            var q = new List<Organizador>().AsQueryable();

            return q.Where(OrganizadorScope.TodosAtivosAnoCorrente(DateTime.Now.Year));
        }
    }
}
