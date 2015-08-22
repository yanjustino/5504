using Nucleo.Core;
using System;

namespace Cadastro.Core.Domain.Model.Eventos
{
    public class EventoId: Identity
    {
        public EventoId() : base()
        {

        }

        public EventoId(Guid id):base(id)
        {

        }
    }
}