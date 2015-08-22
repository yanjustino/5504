using Cadastro.Core.Application.Eventos;
using Cadastro.Core.Application.Organizadores;
using Emissao.Core.Application.Certificados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventoCertificado.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IServicoEvento _servicoEvento;
        private readonly IServicoCertificado _servicoCertificado;


        public DefaultController(IServicoEvento servicoEvento, IServicoCertificado servicoCertificado)
        {
            _servicoEvento = servicoEvento;
            _servicoCertificado = servicoCertificado;
        }

        // GET: Default
        public ActionResult Index(Guid guid, string chave)
        {
            var evento = _servicoEvento.RecuperarEvento(guid);
            var participante = evento.RecuperarParticipantePelaChave(chave);

            // TODO: Validação de participante e evento;

            var command = new CertificadoCommand
            {
                EventoId = evento.EventoId.Id,
                ChavePaticipante = participante.ChaveAcesso,
                NomeParticipante = participante.Nome,
                TemplateId = evento.Tempelate.Id
            };

            var certificado = _servicoCertificado.EmitirCertificado(command);

            return View(certificado.UriCertificado());
        }
    }
}