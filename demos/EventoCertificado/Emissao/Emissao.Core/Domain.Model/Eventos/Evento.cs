using Emissao.Core.Domain.Model.Certificados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissao.Core.Domain.Model.Eventos
{
    public class Evento
    {
        public EventoId EventoId { get; private set; }
        public string NomeEvento { get; private set; }
        public TemplateCertificadoId Template { get; private set; }

        protected Evento() { }
    }
}
