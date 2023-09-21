using webApi.Event_.Lucas.Contexts;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;

namespace webApi.Event_.Lucas.Repositories
{
    public class PresencaEventoRepository : IPresencaEventoRepository
    {
        private readonly EventContext _eventContext;
        public PresencaEventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, PresencaEvento presencaEvento)
        {
            PresencaEvento presencaAtualizada = _eventContext.PresencaEvento.Find(id)!;
            if (presencaAtualizada != null)
            {
                presencaAtualizada.Situacao = presencaEvento.Situacao;
            }
            _eventContext.PresencaEvento.Update(presencaAtualizada!);
            _eventContext.SaveChanges();
        }

        public void Cadastrar(PresencaEvento presencaEvento)
        {
            _eventContext.PresencaEvento.Add(presencaEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            PresencaEvento presencaBuscado = _eventContext.PresencaEvento.Find(id)!;
            _eventContext.PresencaEvento.Remove(presencaBuscado);
            _eventContext.SaveChanges();
        }

        public List<PresencaEvento> Listar()
        {
            throw new NotImplementedException();
            //return _eventContext.TiposEvento.Where(filtro).ToList();
        }
    }
}
