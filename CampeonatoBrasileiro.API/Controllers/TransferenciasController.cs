using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatoBrasileiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciasController : ControllerBase
    {
        private readonly IApplicationServiceTransferencia _applicationServiceTransferencia;

        public TransferenciasController(IApplicationServiceTransferencia ApplicationServiceTransferencia)
        {
            _applicationServiceTransferencia = ApplicationServiceTransferencia;
        }

        // GET api/transferencia
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceTransferencia.GetAll());
        }

        // GET api/cliente/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceTransferencia.GetById(id));
        }

        // POST api/transferencia
        [HttpPost]
        public ActionResult<string> Post([FromBody] TransferenciaDtoCreate transferenciaDto)
        {
            try
            {
                if (transferenciaDto == null)
                    return NotFound();

                _applicationServiceTransferencia.Add(transferenciaDto);
                return Ok("Transferencia cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/transferencia/5
        [HttpPut]
        public ActionResult<string> Put([FromBody] TransferenciaDtoUpdate transferenciaDto)
        {
            try
            {
                if (transferenciaDto == null)
                    return NotFound();

                _applicationServiceTransferencia.Update(transferenciaDto);
                return Ok("Transferencia atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/transferencia/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                _applicationServiceTransferencia.Remove(id);
                return Ok("Transferencia removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}