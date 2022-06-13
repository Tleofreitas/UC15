using ChapterTF.Contexts;
using ChapterTF.Interfaces;
using ChapterTF.Models;

namespace ChapterTF.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ChapterContext _context;
        public UsuarioRepository(ChapterContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(id);

            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;
                usuario.Senha = usuario.Senha;
                
                _context.Usuarios.Update(usuarioEncontrado);

                _context.SaveChanges();
            }

        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        public void Deletar(int id)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(id);

            _context.Usuarios.Remove(usuarioEncontrado);

            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }
    }
}
