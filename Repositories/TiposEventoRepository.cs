using Microsoft.EntityFrameworkCore;
using webApi.Event_.Lucas.Contexts;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;

namespace webApi.Event_.Lucas.Repositories
{
    public class TiposEventoRepository : ITiposEventosRepository
    {
        private readonly EventContext _eventContext;
        public TiposEventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, TiposEvento tipoEvento)
        {
            TiposEvento eventoAtualizado = _eventContext.TiposEvento.Find(id)!;
            if (eventoAtualizado != null)
            {
                eventoAtualizado.Titulo = tipoEvento.Titulo;
            }
            _eventContext.TiposEvento.Update(eventoAtualizado!);
            _eventContext.SaveChanges();
        }

        public TiposEvento BuscarPorId(Guid id)
        {
            return _eventContext.TiposEvento.FirstOrDefault(e => e.IdTipoEvento == id)!;
        }

        public void Cadastrar(TiposEvento tipoEvento)
        {
            _eventContext.TiposEvento.Add(tipoEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposEvento eventoBuscado = _eventContext.TiposEvento.Find(id)!;
            _eventContext.TiposEvento.Remove(eventoBuscado);
            _eventContext.SaveChanges();
        }

        public List<TiposEvento> Listar()
        {
            return _eventContext.TiposEvento.ToList();
        }
    }
}
