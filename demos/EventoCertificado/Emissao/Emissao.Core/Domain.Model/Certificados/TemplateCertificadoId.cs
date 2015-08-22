using Nucleo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissao.Core.Domain.Model.Certificados
{
    public class TemplateCertificadoId : Identity
    {
        public TemplateCertificadoId():base()
        {

        }

        public TemplateCertificadoId(Guid id):base(id)
        {

        }
    }
}
