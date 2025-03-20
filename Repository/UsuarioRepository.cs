using Event_Plus.Context;
using Event_Plus.Domain;
using Event_Plus.Interface;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly EventoContext _context;

    public UsuarioRepository(EventoContext context)
    {
        _context = context;
    }
    public List<Usuario> Listar()
    {
        return _context.Usuarios.ToList();
    }

    public Usuario BuscarPorId(Guid id)
    {
        return _context.Usuarios.Find(id)!;
    }

    public void Cadastrar(Usuario usuarioEvento)
    {
        _context.Usuarios.Add(usuarioEvento);
        _context.SaveChanges();
    }

    public void Atualizar(Guid id, Usuario UsuarioAtualizado)
    {
        Usuario UsuarioBuscado = _context.Usuarios.Find(id)!;

        if (UsuarioBuscado != null)
        {
            UsuarioBuscado.Nome = UsuarioAtualizado.Nome;
            UsuarioBuscado.Email = UsuarioAtualizado.Email;
            UsuarioBuscado.Senha = UsuarioAtualizado.Senha;
            UsuarioBuscado.IdTipoUsuario = UsuarioAtualizado.IdTipoUsuario;
        }
        _context.SaveChanges();
    }

    public void Deletar(Guid id)
    {
        Usuario usuarioBuscado = _context.Usuarios.Find(id)!;
        if (usuarioBuscado != null)
        {
            _context.Usuarios.Remove(usuarioBuscado);
            _context.SaveChanges();
        }
    }



    public Usuario BuscarPorEmailESenha(string email, string senha)
    {
        throw new NotImplementedException();
    }