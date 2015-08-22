using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emissao.Core.Domain.Model.Certificados;
using Emissao.Core.Domain.Model.Eventos;

namespace Emissao.Core.Application.Certificados
{
    public class ServicoCertificado : IServicoCertificado
    {
        private readonly IRepositorioEvento _repositorioEventos;

        public ServicoCertificado(IRepositorioEvento repositorioEventos)
        {
            _repositorioEventos = repositorioEventos;
        }

        public Certificado EmitirCertificado(CertificadoCommand command)
        {
            var evento = _repositorioEventos.RecuperarPorEventoId(new EventoId(command.EventoId));
            var certificado = new Certificado(evento.EventoId, command.NomeParticipante, command.ChavePaticipante);

            // TODO : Persistir certificado
            // Disparar pelo domain Events o redirect para a view de emissão
            throw new NotImplementedException();
        }
    }
}
