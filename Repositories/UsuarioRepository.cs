﻿using webApi.Event_.Lucas.Contexts;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;
using webApi.Event_.Lucas.Utils;

namespace webApi.Event_.Lucas.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventContext _eventContext;

        public UsuarioRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, Usuario usuario)
        {
            Usuario usuarioAtualizado = _eventContext.Usuario.Find(id)!;
            if (usuarioAtualizado != null)
            {
                usuarioAtualizado.Nome = usuario.Nome;
            }
            _eventContext.Usuario.Update(usuarioAtualizado!);
            _eventContext.SaveChanges();
        }

        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _eventContext.Usuario
                     .Select(u => new Usuario
                     {
                         IdUsuario = u.IdUsuario,
                         Nome = u.Nome,
                         Email = u.Email,
                         Senha = u.Senha,
                         TiposUsuario = new TiposUsuario
                         {
                             IdTipoUsuario = u.IdTipoUsuario,
                             Titulo = u.TiposUsuario!.Titulo
                         }
                     }).FirstOrDefault(usuario => usuario.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuario = _eventContext.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email= u.Email,
                        Senha= u.Senha,
                        TiposUsuario = new TiposUsuario
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            Titulo = u.TiposUsuario!.Titulo
                        }
                    }).FirstOrDefault(usuario => usuario.IdUsuario == id)!;

                if (usuario != null)
                {
                    return usuario;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                _eventContext.Usuario.Add(usuario);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Usuario usuarioBuscado = _eventContext.Usuario.Find(id)!;
            _eventContext.Usuario.Remove(usuarioBuscado);
            _eventContext.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _eventContext.Usuario.ToList();
        }
    }
}
