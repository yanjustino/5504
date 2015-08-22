using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class OrganizadorScope
    {
        public static Expression<Func<Organizador, bool>> TodosAtivos =>
            x => x.Ativo == true;
        
        public static Expression<Func<Organizador, bool>> TodosAtivosAnoCorrente(int ano) =>
            x => x.Ativo == true && x.DataCadastro.Year == ano;
    }
}
