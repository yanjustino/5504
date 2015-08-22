using Emissao.Core.Domain.Model.Certificados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissao.Core.Application.Certificados
{
    public interface IServicoCertificado
    {
        Certificado EmitirCertificado(CertificadoCommand command);
    }
}
