using webApi.Event_.Lucas.Contexts;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;

namespace webApi.Event_.Lucas.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext _eventContext;
        public EventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, Evento evento)
        {
            Evento eventoAtualizado = _eventContext.Evento.Find(id)!;
            if (eventoAtualizado != null)
            {
                eventoAtualizado.NomeEvento = evento.NomeEvento;
                eventoAtualizado.DataEvento = evento.DataEvento;
                eventoAtualizado.Descricao = evento.Descricao;
            }
            _eventContext.Evento.Update(eventoAtualizado!);
            _eventContext.SaveChanges();
        }

        public Evento BuscarPorId(Guid id)
        {
            try
            {
                Evento evento = _eventContext.Evento
                    .Select(u => new Evento
                    {
                        IdEvento = u.IdEvento,
                        NomeEvento = u.NomeEvento,
                        DataEvento = u.DataEvento,
                        Descricao = u.Descricao,
                        TiposEvento = new TiposEvento
                        {
                            IdTipoEvento = u.IdTipoEvento,
                            Titulo = u.TiposEvento!.Titulo
                        }
                    }).FirstOrDefault(evento => evento.IdEvento == id)!;

                if (evento != null)
                {
                    return evento;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Evento evento)
        {
            _eventContext.Evento.Add(evento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Evento eventoBuscado = _eventContext.Evento.Find(id)!;
            _eventContext.Evento.Remove(eventoBuscado);
            _eventContext.SaveChanges();
        }

        List<Evento> IEventoRepository.Listar()
        {
            return _eventContext.Evento.ToList();
        }
    }
}
