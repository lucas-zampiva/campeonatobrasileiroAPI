using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatoBrasileiro.API.Controllers
{
    [Route("api/torneios")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly IApplicationServiceEvento _applicationServiceEvento;

        public EventosController(IApplicationServiceEvento ApplicationServiceEvento)
        {
            _applicationServiceEvento = ApplicationServiceEvento;
        }

        // private POST api/jogador
        [HttpPost("{idTorneio}/partidas/{idPartida}/eventos/inicio")]
        public ActionResult<string> Post([FromBody] EventoDto eventoDto, [FromRoute] int idTorneio, [FromRoute] int idPartida)
        {
            try
            {
                if (eventoDto == null)
                    return NotFound();

                _applicationServiceEvento.Add(eventoDto);
                return Ok("Evento cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}