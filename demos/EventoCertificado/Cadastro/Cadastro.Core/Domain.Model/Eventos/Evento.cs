using Cadastro.Core.Domain.Model.Organizadores;
using Nucleo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Eventos
{
    public class Evento
    {
        public EventoId EventoId { get; private set; }
        public OrganizadorId OrganizadorId { get; private set; }
        public TemplateCertificadoId Tempelate { get; private set; }
        public ICollection<Participante> Participantes { get; private set; }
        public Periodo PeriodoEntregaCertificado { get; private set; }
        public string Nome { get; private set; }


        protected Evento() { }

        public Evento(EventoId eventoId, OrganizadorId organizadorId, string nome)
        {
            EventoId = eventoId;
            OrganizadorId = organizadorId;
            Nome = nome;

            Participantes = new List<Participante>();
        }

        public void AdicionarParticipante(Participante participante)
        {
            Participantes.Add(participante);
        }

        public void AtualizarListaDeParticipantes(ICollection<Participante> participantes)
        {
            Participantes.Clear();
            Participantes = participantes;
        }

        public Participante RecuperarParticipantePelaChave(string chave)
        {
           return Participantes.FirstOrDefault(p => p.ChaveAcesso == chave);
        }

        public void AtribuirTemaplate(TemplateCertificadoId templateCertificadoId)
        {
            this.Tempelate = templateCertificadoId;
        }
    }
}
