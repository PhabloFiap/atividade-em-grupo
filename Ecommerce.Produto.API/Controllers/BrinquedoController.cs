using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Produto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrinquedoController : ControllerBase
    {
        private readonly IBrinquedoApplicationService _brinquedoApplicationService;

        public BrinquedoController(IBrinquedoApplicationService brinquedoApplicationService)
        {
            _brinquedoApplicationService = brinquedoApplicationService;
        }

        /// <summary>
        /// Metodo para retornar todos os dados de brinquedo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<BrinquedoEntity>>]
        public IActionResult Get()
        {
            var brinquedos = _brinquedoApplicationService.ObterTodasBrinquedos();

            if(brinquedos is not null)
                return Ok(brinquedos);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Metodo para retornar uma brinquedo
        /// </summary>
        /// <param name="id"> Codigo identificador da brinquedo</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<BrinquedoEntity>]
        public IActionResult GetPorId(int id)
        {
            var brinquedos = _brinquedoApplicationService.ObterBrinquedosPorId(id);

            if (brinquedos is not null)
                return Ok(brinquedos);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Metodo para salvar os dados da brinquedo
        /// </summary>
        /// <param name="entity"> Modelo de dados da brinquedo</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<BrinquedoEntity>]
        public IActionResult Post([FromBody] BrinquedoEntity entity)
        {
            var brinquedos = _brinquedoApplicationService.SalverDadosBrinquedo(entity);

            if (brinquedos is not null)
                return Ok(brinquedos);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Metodo para editar os dados da brinquedo
        /// </summary>
        /// <param name="entity"> Modelo de dados da brinquedo</param>
        /// <returns></returns>
        [HttpPut]
        [Produces<BrinquedoEntity>]
        public IActionResult Put([FromBody] BrinquedoEntity entity)
        {
            var brinquedos = _brinquedoApplicationService.EditarDadosBrinquedo(entity);

            if (brinquedos is not null)
                return Ok(brinquedos);

            return BadRequest("Não foi possivel alterar os dados");
        }

        /// <summary>
        /// Metodo para deletar uma brinquedo
        /// </summary>
        /// <param name="id"> Codigo identificador da brinquedo</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<BrinquedoEntity>]
        public IActionResult Deletar(int id)
        {
            var brinquedos = _brinquedoApplicationService.DeletarDadosBrinquedo(id);

            if (brinquedos is not null)
                return Ok(brinquedos);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
