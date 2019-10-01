using LivrariaWebApi.Dto;
using LivrariaBusiness;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroBusiness livroBusiness;

        public LivroController()
        {
            livroBusiness = new LivroBusiness();
        }

        // /// <summary>
        // /// Retorna os registros salvos por usuario
        // /// </summary>
        // /// <param name="usuario">Usuário a ser pesquisado</param>
        // [ProducesResponseType(typeof(Exception), 500)]
        // [ProducesResponseType(typeof(IEnumerable<LivrariaDto>), 200)]
        // [HttpGet("{usuario}")]
        // public ActionResult Get(string usuario)
        // {
        //     IEnumerable<Livraria> auditorias = auditoriaBusiness.Get(usuario);
        //     IEnumerable<AuditoriaDto> auditoriaDtos = auditorias.Select(x => new AuditoriaDto
        //     {
        //         Acao = x.Acao,
        //         Data = x.Data,
        //         Sucesso = x.Sucesso,
        //         Usuario = x.Usuario
        //     });

        //     return Ok(auditoriaDtos);
        // }

        // /// <summary>
        // /// Insere novo registro de auditoria
        // /// </summary>
        // /// <param name="auditoria">Dados para auditoria</param>
        // [ProducesResponseType(typeof(Exception), 500)]
        // [ProducesResponseType(200)]
        // [HttpPost]
        // public ActionResult Post([FromBody] AuditoriaDto auditoria)
        // {
        //     return Ok();
        // }
    }
}