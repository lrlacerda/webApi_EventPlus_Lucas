using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuario tipoUsuario);
        void Deletar(Guid id);
        List<TiposUsuario> Listar();
        TiposUsuario BuscarPorId();
        void Atualizar(Guid id, TiposUsuario tipoUsuario);
    }
}
