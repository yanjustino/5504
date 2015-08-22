using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissao.Core.Application.Certificados
{
    public class CertificadoCommand
    {
        public Guid EventoId { get; set; }
        public string NomeParticipante { get; set; }
        public string ChavePaticipante { get; set; }
        public Guid TemplateId { get; set; }
    }
}
