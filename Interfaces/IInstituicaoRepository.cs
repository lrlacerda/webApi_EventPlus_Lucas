using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Interfaces
{
    public interface IInstituicaoRepository
    {
        void Cadastrar(Instituicao instituicao);
        void Deletar(Guid id);
        List<Instituicao> Listar();
        Instituicao BuscarPorId();
        void Atualizar(Guid id, Instituicao instituicao);
    }
}
