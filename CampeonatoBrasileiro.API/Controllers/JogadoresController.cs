using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatoBrasileiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadoresController : ControllerBase
    {
        private readonly IApplicationServiceJogador _applicationServiceJogador;

        public JogadoresController(IApplicationServiceJogador ApplicationServiceJogador)
        {
            _applicationServiceJogador = ApplicationServiceJogador;
        }

        // GET api/jogador
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceJogador.GetAll());
        }

        // GET api/jogador/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceJogador.GetById(id));
        }

        // POST api/jogador
        [HttpPost]
        public ActionResult<string> Post([FromBody] JogadorDtoCreate jogadorDto)
        {
            try
            {
                if (jogadorDto == null)
                    return NotFound();

                _applicationServiceJogador.Add(jogadorDto);
                return Ok("Jogador cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/jogador
        [HttpPut]
        public ActionResult<string> Put([FromBody] JogadorDtoUpdate jogadorDto)
        {
            try
            {
                if (jogadorDto == null || jogadorDto.Id == null)
                    return NotFound("Jogador não encontrado");

                _applicationServiceJogador.Update(jogadorDto);
                return Ok("Jogador atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Delete api/jogador/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                _applicationServiceJogador.Remove(id);
                return Ok("Jogador removido com sucesso!");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}