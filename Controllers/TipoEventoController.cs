using Event_Plus.Context;
using Event_Plus.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace EventPLUS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoEventoController : ControllerBase
    {

        private readonly Event_Context _tipoEventoRepository;
        public TipoEventoController(Event_Context tipoEventoRepository)
        {
            _tipoEventoRepository = tipoEventoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoEventoRepository.Evento.ToList());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpPost("Cadastrar")]

        public IActionResult Post(TipoEvento tipoEvento)
        {

            try
            {
                _tipoEventoRepository.TipoEvento.Add(tipoEvento);
                _tipoEventoRepository.SaveChanges();
                return Ok(tipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("BuscarPorId/{id}")]

        public IActionResult GetById(Guid id)
        {
            try
            {
                TipoEvento tipoEvento = _tipoEventoRepository.TipoEvento.Find(id)!;
                if (tipoEvento == null)
                {
                    return NotFound();
                }
                return Ok(tipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                TipoEvento tipoEvento = _tipoEventoRepository.TipoEvento.Find(id)!;
                if (tipoEvento == null)
                {
                    return NotFound();
                }
                _tipoEventoRepository.TipoEvento.Remove(tipoEvento);
                _tipoEventoRepository.SaveChanges();
                return Ok(tipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        

            [HttpPut("{id}")]
            public IActionResult Put(Guid id, TipoEvento tiposEventos)
            {
                try
                {
                    _tipoEventoRepository.Atualizar(Guid id, TipoEvento tiposEventos);
                    return NoContent();
                }
                catch (Exception e)
                {

                    return BadRequest(e.Message);
                }
            }








        }
        

    }
}