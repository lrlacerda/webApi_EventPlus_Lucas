using webApi.Event_.Lucas.Contexts;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;

namespace webApi.Event_.Lucas.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext _eventContext;
        public TiposUsuarioRepository() 
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public TiposUsuario BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
