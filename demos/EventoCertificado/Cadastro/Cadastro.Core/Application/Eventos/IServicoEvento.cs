using Cadastro.Core.Domain.Model.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Application.Eventos
{
    public interface IServicoEvento
    {
        Evento RecuperarEvento(Guid eventoId);
    }
}
