using Event_Plus.Controllers;
using Event_Plus.Domain;
using ProjectEventsPlus.Domain;

namespace Event_Plus.Interface
{
    public interface IComentarioRepository
    {
        void cadastrar(Comentario comentarioEvento);

        void Deletar(Guid id);

       List<Comentario> Listar( Guid Id );

        Comentario BuscarPorId(Guid UsuarioId, Guid IdEvento);
    }
}
