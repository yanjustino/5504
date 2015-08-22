using Emissao.Core.Domain.Model.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissao.Core.Domain.Model.Certificados
{
    public class Certificado
    {
        public Guid Id { get; private set; }
        public EventoId EventoId { get; private set; }
        public TemplateCertificadoId Template { get; set; }
        public DateTime Emissao { get; private set; }
        public string NomeParticipante { get; private set; }
        public string ChaveParticiapnte { get; set; }

        protected Certificado() { }

        public Certificado(EventoId eventoId, string nomeParticipante, string chaveParticiante)
        {
            EventoId = eventoId;
            NomeParticipante = nomeParticipante;
        }

        public string UriCertificado()
        {
            return Template.Id.ToString();
        }
    }
}
