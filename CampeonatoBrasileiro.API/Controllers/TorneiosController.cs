using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatoBrasileiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TorneiosController : ControllerBase
    {
        private readonly IApplicationServiceTorneio _applicationServiceTorneio;

        public TorneiosController(IApplicationServiceTorneio ApplicationServiceTorneio)
        {
            _applicationServiceTorneio = ApplicationServiceTorneio;
        }

        // GET api/torneio
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceTorneio.GetAll());
        }

        // GET api/torneio/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceTorneio.GetById(id));
        }

        // POST api/torneio
        [HttpPost]
        public ActionResult<string> Post([FromBody] TorneioDtoCreate TorneioDto)
        {
            try
            {
                if (TorneioDto == null)
                    return NotFound();

                _applicationServiceTorneio.Add(TorneioDto);
                return Ok("Torneio cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/torneio
        [HttpPut]
        public ActionResult<string> Put([FromBody] TorneioDtoUpdate TorneioDto)
        {
            try
            {
                if (TorneioDto == null)
                    return NotFound();

                _applicationServiceTorneio.Update(TorneioDto);
                return Ok("Torneio atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/torneio/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                _applicationServiceTorneio.Remove(id);
                return Ok("Torneio excluído com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/torneio
        [Route("time")]
        [HttpPost]
        public ActionResult<string> PostTimeTorneio([FromBody] TorneioTimeDto TorneioTimeDto)
        {
            try
            {
                if (TorneioTimeDto == null)
                    return NotFound();

                _applicationServiceTorneio.AddTime(TorneioTimeDto);
                return Ok("Time adicionado ao torneio com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}