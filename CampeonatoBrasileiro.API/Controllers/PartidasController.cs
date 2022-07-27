using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatoBrasileiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidasController : Controller
    {
        private readonly IApplicationServicePartida _applicationServicePartida;

        public PartidasController(IApplicationServicePartida ApplicationServicePartida)
        {
            _applicationServicePartida = ApplicationServicePartida;
        }

        // GET api/partida
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServicePartida.GetAll());
        }

        // GET api/partida/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicePartida.GetById(id));
        }

        // POST api/partida
        [HttpPost]
        public ActionResult<string> Post([FromBody] PartidaDtoCreate partidaDto)
        {
            try
            {
                if (partidaDto == null)
                    return NotFound();

                _applicationServicePartida.Add(partidaDto);
                return Ok("Partida cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/partida
        [HttpPut]
        public ActionResult<string> Put([FromBody] PartidaDtoUpdate partidaDto)
        {
            try
            {
                if (partidaDto == null || partidaDto.Id == null)
                    return NotFound("Partida não encontrado");

                _applicationServicePartida.Update(partidaDto);
                return Ok("Partida atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Delete api/partida/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                _applicationServicePartida.Remove(id);
                return Ok("Partida removido com sucesso!");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}