using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha(string email, string senha);
    }
}
