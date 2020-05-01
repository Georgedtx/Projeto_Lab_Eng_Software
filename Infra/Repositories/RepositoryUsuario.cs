using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryUsuario : Repository<Usuario>, IRepositoryUsuario
    {
        public RepositoryUsuario(ProjectContext _context) : base(_context) { }

        public Usuario ObterPorId(Guid id) {

            return _context.Usuarios.Include("Usuario").Where(u => u.Id == id).FirstOrDefault();
        }

        public Usuario ObterPorEmail(string email) {

            return _context.Usuarios.Where(u => u.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();
        }
    }
}