using AuditoriaDomain;
using AuditoriaWebApi.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuditoriaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class AuditoriaController : ControllerBase
    {
        private readonly AuditoriaBusiness.AuditoriaBusiness auditoriaBusiness;

        public AuditoriaController()
        {
            auditoriaBusiness = new AuditoriaBusiness.AuditoriaBusiness();
        }

        /// <summary>
        /// Retorna os registros salvos por usuario
        /// </summary>
        /// <param name="usuario">Usuário a ser pesquisado</param>
        [ProducesResponseType(typeof(Exception), 500)]
        [ProducesResponseType(typeof(IEnumerable<AuditoriaDto>), 200)]
        [HttpGet("{usuario}")]
        public ActionResult Get(string usuario)
        {
            IEnumerable<Auditoria> auditorias = auditoriaBusiness.Get(usuario);
            IEnumerable<AuditoriaDto> auditoriaDtos = auditorias.Select(x => new AuditoriaDto
            {
                Acao = x.Acao,
                Data = x.Data,
                Sucesso = x.Sucesso,
                Usuario = x.Usuario
            });

            return Ok(auditoriaDtos);
        }

        /// <summary>
        /// Insere novo registro de auditoria
        /// </summary>
        /// <param name="auditoria">Dados para auditoria</param>
        [ProducesResponseType(typeof(Exception), 500)]
        [ProducesResponseType(200)]
        [HttpPost]
        public ActionResult Post([FromBody] AuditoriaDto auditoria)
        {
            return Ok();
        }
    }
}