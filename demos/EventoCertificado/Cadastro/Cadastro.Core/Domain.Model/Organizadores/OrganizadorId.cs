using Nucleo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class OrganizadorId : Identity
    {
        public OrganizadorId() : base() { }
        public OrganizadorId(Guid id) : base(id) { }
    }
}
