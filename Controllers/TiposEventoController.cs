using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Event_.Lucas.Domains;
using webApi.Event_.Lucas.Interfaces;
using webApi.Event_.Lucas.Repositories;

namespace webApi.Event_.Lucas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposEventoController : ControllerBase
    {
        private ITiposEventosRepository _tiposEventoRepository;

        public TiposEventoController()
        {
            _tiposEventoRepository = new TiposEventoRepository();
        }

        [HttpPost]

        public IActionResult Post(TiposEvento tiposEvento) 
        {
            try
            {
                _tiposEventoRepository.Cadastrar(tiposEvento);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
