using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Interfaces
{
    public interface ITiposEventosRepository
    {
        void Cadastrar(TiposEvento tipoEvento);
        void Deletar(Guid id);
        List<TiposEvento> Listar();
        TiposEvento BuscarPorId();
        void Atualizar(Guid id, TiposEvento tipoEvento);
    }
}
