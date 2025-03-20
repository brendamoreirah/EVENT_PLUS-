using Event_Plus.Context;

public class EventoRepository : IEventosRepository
{
    private readonly EventoContext _context;

    public EventoRepository(EventoContext context)
    {
        _context = context;
    }


    public List<Evento> Listar()
    {
        return _context.Eventos.ToList();
    }
    //Desenvolver os metodos que foram
    //criados na minha interface
    // Método para buscar um tipo de evento pelo ID
    public Evento BuscarPorId(Guid id)
    {
        return _context.Eventos.Find(id)!;
    }

    // Método para cadastrar um novo tipo de evento
    public void Cadastrar(Evento evento)
    {
        _context.Eventos.Add(evento);
        _context.SaveChanges();
    }

    // Método para atualizar um tipo de evento existente
    public void Atualizar(Guid id, Evento eventoAtualizado)
    {
        Evento eventoBuscado = _context.Eventos.Find(id)!;

        if (eventoBuscado != null)
        {
            _context.SaveChanges();
            eventoBuscado.NomeEvento = eventoAtualizado.NomeEvento;
            eventoBuscado.Descricao = eventoAtualizado.Descricao;

            _context.Eventos.Update(eventoBuscado);
        }
    }


    public void Deletar(Guid id)
    {
        throw new NotImplementedException();
    }


    public List<Evento> ListarPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Evento> ProximosEventos()
    {
        throw new NotImplementedException();
    }
}