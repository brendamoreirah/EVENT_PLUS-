using Event_Plus.Context;
using Event_Plus.Domain;
using Event_Plus.Interface;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly Event_Context _context;

    public UsuarioRepository(Event_Context context)
    {
        _context = context;
    }
    public List<Usuario> Listar()
    {
        return _context.Usuario.ToList();
    }

    public Usuario BuscarPorId(Guid id)
    {
        return _context.Usuario.Find(id)!;
    }

    public void Cadastrar(Usuario usuarioEvento)
    {
        _context.Usuario.Add(usuarioEvento);
        _context.SaveChanges();
    }

    public void Atualizar(Guid id, Usuario UsuarioAtualizado)
    {
        Usuario UsuarioBuscado = _context.Usuario.Find(id)!;

        if (UsuarioBuscado != null)
        {
            UsuarioBuscado.NomeUsuario = UsuarioAtualizado.NomeUsuario;
            UsuarioBuscado.EmailUsuario = UsuarioAtualizado.EmailUsuario;
            UsuarioBuscado.SenhaUsuario = UsuarioAtualizado.SenhaUsuario;
            UsuarioBuscado.TipoUsuarioId = UsuarioAtualizado.TipoUsuarioId;
        }
        _context.SaveChanges();
    }

    public void Deletar(Guid id)
    {
        Usuario usuarioBuscado = _context.Usuario.Find(id)!;
        if (usuarioBuscado != null)
        {
            _context.Usuario.Remove(usuarioBuscado);
            _context.SaveChanges();
        }
    }



    public Usuario BuscarPorEmailESenha(string email, string senha)
    {
        throw new NotImplementedException();
    }

    public Usuario BuscarPoEmaileSenha(string email, string senha)
    {
        throw new NotImplementedException();
    }
}
