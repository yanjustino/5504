using Nucleo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissao.Core.Domain.Model.Eventos
{
    public class EventoId : Identity
    {
        public EventoId() : base() { }
        public EventoId(Guid id) : base(id) { }
    }
}
