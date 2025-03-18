using Event_Plus.Domain;
using ProjectEventsPlus.Domain;

namespace Event_Plus.Interface
{
    public interface IPresencaRepository
    {

        void Deletar(Guid id);


        List<Presenca> listar();

        Presenca BuscarPorId(Guid id);

        void Atualizar(Guid Id, Presenca presenca);

        List<Presenca> ListarMinhasPresenca(Guid Id);

        void Inscrever(Presenca presenca);
    }
}
