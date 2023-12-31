﻿using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Interfaces
{
    public interface ITiposEventosRepository
    {
        void Cadastrar(TiposEvento tipoEvento);
        void Deletar(Guid id);
        List<TiposEvento> Listar();
        void Atualizar(Guid id, TiposEvento tipoEvento);
    }
}
