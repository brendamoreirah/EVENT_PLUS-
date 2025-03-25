
using Event_Plus.Domain;
using Event_Plus.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Event_Plus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioRepository _feedbackRepository;

        public ComentarioController(IComentarioRepository ComentarioRepository)
        {
            ComentarioRepository = ComentarioRepository;

        }

        /// <summary>
        /// Endpoint para cadastrar Feedbackss
        /// </summary>
        /// <param name="novoFeedback"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Comentario novoComentario)
        {
            try
            {
                _ComentarioRepository.cadastrar(novoComentario);
                return Created();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        /// <summary>
        /// Endpoint para listar Feedbacks
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_ComentarioRepository.lista());

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        /// <summary>
        /// Endpoint para deletar Feedbacks
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _ComentarioRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Endpoint para buscar Feedbacks por Id dos usuarios
        /// </summary>
        /// <param name="UsuarioId"></param>
        /// <param name="EventoId"></param>
        /// <returns></returns>
        [HttpGet("BuscarPorIdUsuario/{UsuarioId},{EventoId}")]
        public IActionResult GetById(Guid UsuarioId, Guid EventoId)
        {
            try
            {
                Comentario novoComentario = _ComentarioRepository.BuscarPorIdUsuario(UsuarioId, EventoId);
                return Ok(novoComentario);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }

        }



    }
}