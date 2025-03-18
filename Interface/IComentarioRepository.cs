using Event_Plus.Controllers;
using Event_Plus.Domain;
using ProjectEventsPlus.Domain;

namespace Event_Plus.Interface
{
    public interface IComentarioRepository
    {
        void cadastrar(Comentario comentarioEvebto);

        void Deletar(int idComentario);

       List<Comentario> lista( Guid Id );

        Comentario BuscarPorId(Guid UsuarioId, Guid IdEvento);
    }
}
