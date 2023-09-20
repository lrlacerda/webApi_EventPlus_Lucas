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
            throw new NotImplementedException();
        }

        public TiposEvento BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposEvento tipoEvento)
        {
            _eventContext.TiposEvento.Add(tipoEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            _eventContext.TiposEvento.Remove(BuscarPorId());
            _eventContext.SaveChanges();
        }

        public List<TiposEvento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
