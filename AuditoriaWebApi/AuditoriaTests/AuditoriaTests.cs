using AuditoriaDomain;
using System;
using System.Linq;
using Xunit;

namespace AuditoriaTests
{
    public class AuditoriaTests
    {
        private readonly AuditoriaBusiness.AuditoriaBusiness auditoriaBusiness;

        public AuditoriaTests()
        {
            auditoriaBusiness = new AuditoriaBusiness.AuditoriaBusiness();
        }

        [Fact]
        [Trait(nameof(AuditoriaBusiness.AuditoriaBusiness.Add), "Sucesso")]
        public void Add_Sucesso()
        {
            Auditoria auditoria = new Auditoria
            {
                Acao = "TESTE",
                Data = DateTime.Parse("30/09/2019 12:02:54"),
                Sucesso = true,
                Usuario = "geysa.fernandes"
            };

            auditoriaBusiness.Add(auditoria);
        }

        [Fact]
        [Trait(nameof(AuditoriaBusiness.AuditoriaBusiness.Get), "Sucesso")]
        public void Get_Sucesso()
        {
            var resultado = auditoriaBusiness.Get("geysa.fernandes");
            Assert.Equal("geysa.fernandes", resultado.First().Usuario);
        }
    }
}
