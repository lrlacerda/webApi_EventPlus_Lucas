using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Interfaces
{
    public interface IComentariosEventoRepository
    {
        void Cadastrar(ComentariosEvento comentarioEvento);
        void Deletar(Guid id);
        List<TiposEvento> Listar();
    }
}
