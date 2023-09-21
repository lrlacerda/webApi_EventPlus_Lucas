using Microsoft.EntityFrameworkCore.Diagnostics;
using webApi.Event_.Lucas.Contexts;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;

namespace webApi.Event_.Lucas.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private readonly EventContext _eventContext;
        public InstituicaoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, Instituicao instituicao)
        {
            Instituicao isntituicaoAtualizada = _eventContext.Instituicao.Find(id)!;
            if (isntituicaoAtualizada != null)
            {
                isntituicaoAtualizada.Endereco = instituicao.Endereco;
                isntituicaoAtualizada.NomeFantasia = instituicao.NomeFantasia;
                isntituicaoAtualizada.Endereco = instituicao.CNPJ;
            }
            _eventContext.Instituicao.Update(isntituicaoAtualizada!);
            _eventContext.SaveChanges();
        }

        public Instituicao BuscarPorId(Guid id)
        {
            return _eventContext.Instituicao.FirstOrDefault(e => e.IdInstituicao == id)!;
        }

        public Instituicao BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Instituicao instituicao)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Instituicao> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
