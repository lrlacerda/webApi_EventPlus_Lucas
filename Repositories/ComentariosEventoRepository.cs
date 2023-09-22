using webApi.Event_.Lucas.Contexts;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;

namespace webApi.Event_.Lucas.Repositories
{
    public class ComentariosEventoRepository : IComentariosEventoRepository
    {
        private readonly EventContext _eventContext;
        public ComentariosEventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Cadastrar(ComentariosEvento comentarioEvento)
        {
            _eventContext.ComentariosEvento.Add(comentarioEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            ComentariosEvento comentarioBuscado = _eventContext.ComentariosEvento.Find(id)!;
            _eventContext.ComentariosEvento.Remove(comentarioBuscado);
            _eventContext.SaveChanges();
        }

        List<ComentariosEvento> IComentariosEventoRepository.Listar()
        {
            return _eventContext.ComentariosEvento.ToList(); ;
        }

        public List<ComentariosEvento> ListarComentariosPorUsuario(Guid idUsuario)
        {
            return _eventContext.ComentariosEvento
                .Where(comentario => comentario.IdUsuario == idUsuario)
                .ToList();
        }
    }
}
