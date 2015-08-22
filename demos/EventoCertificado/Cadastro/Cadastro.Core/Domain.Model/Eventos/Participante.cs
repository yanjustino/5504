namespace Cadastro.Core.Domain.Model.Eventos
{
    public class Participante
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public EventoId EventoId { get; private set; }
        public string ChaveAcesso { get; private set; }

        protected Participante() { }

        public Participante(string nome, string email, EventoId eventoId, string chave)
        {
            Nome = nome;
            Email = email;
            EventoId = eventoId;
            ChaveAcesso = chave;
        }
    }
}