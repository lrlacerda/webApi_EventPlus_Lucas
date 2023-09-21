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
            TiposUsuario usuarioAtualizado = _eventContext.TiposUsuario.Find(id)!;
            if (usuarioAtualizado != null)
            {
                usuarioAtualizado.Titulo = tipoUsuario.Titulo;
            }
            _eventContext.TiposUsuario.Update(usuarioAtualizado!);
            _eventContext.SaveChanges();
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario usuarioBuscado = _eventContext.TiposUsuario.Find(id)!;
            _eventContext.TiposUsuario.Remove(usuarioBuscado);
            _eventContext.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return _eventContext.TiposUsuario.ToList();
        }
    }
}
