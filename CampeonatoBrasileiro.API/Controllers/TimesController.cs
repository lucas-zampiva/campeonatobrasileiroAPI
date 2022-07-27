using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatoBrasileiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesController : ControllerBase
    {
        private readonly IApplicationServiceTime _applicationServiceTime;

        public TimesController(IApplicationServiceTime ApplicationServiceTime)
        {
            _applicationServiceTime = ApplicationServiceTime;
        }

        // GET api/time
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceTime.GetAll());
        }

        // GET api/time/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceTime.GetById(id));
        }

        // POST api/time
        [HttpPost]
        public ActionResult<string> Post([FromBody] TimeDtoCreate timeDto)
        {
            try
            {
                if (timeDto == null)
                    return NotFound();

                _applicationServiceTime.Add(timeDto);
                return Ok("Time cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/time
        [HttpPut]
        public ActionResult<string> Put([FromBody] TimeDto timeDto)
        {
            try
            {
                if (timeDto == null)
                    return NotFound();

                _applicationServiceTime.Update(timeDto);
                return Ok("Time atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/time/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                _applicationServiceTime.Remove(id);
                return Ok("Time excluído com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}