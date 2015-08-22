using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissao.Core.Domain.Model.Eventos
{
    public interface IRepositorioEvento
    {
        Evento RecuperarPorEventoId(EventoId eventoId);
    }
}
