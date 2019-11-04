using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtacadistaWebApi.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AtacadistaWebApi.Controllers
{
    [Route("api/pedido")]
    [ApiVersion("1.0")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        /// <summary>
        /// Recebe um novo pedido
        /// </summary>
        /// <param name="pedido">Objeto contendo os dados do pedido: Id do produto, quantidadee observacoes</param>
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(Exception), 500)]
        [ProducesResponseType(200)]
        public IActionResult NovoPedido([FromBody] Pedido pedido)
        {
            return Ok("pedido recebido");
        }

        /// <summary>
        /// Envia uma notificacao com o orcamento do pedido
        /// </summary>
        /// <param name="orcamento">Objeto contendo os dados do orcamento: Id, preco e data de entrega</param>
        [HttpPost]
        [Route("orcamento")]
        [ProducesResponseType(typeof(Exception), 500)]
        [ProducesResponseType(200)]
        public IActionResult Orcamento([FromBody] Orcamento orcamento)
        {
            return Ok("orcamento enviado");
        }

        /// <summary>
        /// Recebe notificacao do logista se o orcamento foi aprovado
        /// </summary>
        /// <param name="id">Id do pedido</param>
        /// <param name="aprova">Boleano indicando se o orcamento foi aprovado</param>
        [HttpPost]
        [Route("{id}/{aprova}")]
        [ProducesResponseType(typeof(Exception), 500)]
        [ProducesResponseType(200)]
        public IActionResult Orcamento(int id, bool aprova)
        {
            return Ok($"Pedido {id} aprovado? {aprova}");
        }

        /// <summary>
        /// Notifica o logista o status atual do pedido
        /// </summary>
        /// <param name="id">Id do pedido</param>
        /// <param name="status">Status indicando o status atual do pedido</param>
        [HttpPost]
        [Route("{id}/{status}")]
        [ProducesResponseType(typeof(Exception), 500)]
        [ProducesResponseType(200)]
        public IActionResult Orcamento(int id, Status status)
        {
            return Ok($"Pedido {id} status: {status}");
        }
    }
}