using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Interfaces
{
    public interface IPresencaEventoRepository
    {
        void Cadastrar(PresencaEvento presencaEvento);
        void Deletar(Guid id);
        List<PresencaEvento> Listar();
        void Atualizar(Guid id, PresencaEvento presencaEvento);
        public List<PresencaEvento> ListarEventosPorUsuario(Guid idUsuario);
    }
}
