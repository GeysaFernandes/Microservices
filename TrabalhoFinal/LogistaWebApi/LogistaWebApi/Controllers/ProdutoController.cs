using Microsoft.AspNetCore.Mvc;
using System;

namespace LogistaWebApi.Controllers
{
    [Route("api/produto")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        /// <summary>
        /// Retorna a quantidade de produtos no estoque
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Quantidade do produto em estoque</returns>
        [HttpGet]
        [Route("{id}/estoque")]
        [ProducesResponseType(typeof(Exception), 500)]
        [ProducesResponseType(typeof(int), 200)]
        public IActionResult Estoque([FromRoute] int id)
        {
            return Ok(3);
        }
    }
}