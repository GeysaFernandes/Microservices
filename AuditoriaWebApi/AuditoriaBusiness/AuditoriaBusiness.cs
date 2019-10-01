using AuditoriaDomain;
using System;
using System.Collections.Generic;

namespace AuditoriaBusiness
{
    public class AuditoriaBusiness
    {
        /// <summary>
        /// Insere novo registro de auditoria
        /// </summary>
        /// <param name="auditoria">Dados para auditoria</param>
        public void Add(Auditoria auditoria)
        {
            //Insere novo registro para auditoria
        }

        /// <summary>
        /// Retorna os registros salvos por usuario
        /// </summary>
        /// <param name="usuario">Usuário a ser pesquisado</param>
        public IEnumerable<Auditoria> Get(string usuario)
        {
            return new List<Auditoria> {
                new Auditoria { Acao = "Login", Data = DateTime.Parse("30/09/2019 15:24:03"), Usuario = usuario, Sucesso = true},
                new Auditoria { Acao = "PesquisaLivros", Data = DateTime.Parse("30/09/2019 15:30:11"), Usuario = usuario, Sucesso = true},
                new Auditoria { Acao = "DetalhesLivro", Data = DateTime.Parse("30/09/2019 15:40:02"), Usuario = usuario, Sucesso = true},
                new Auditoria { Acao = "AdicionaCarrinho", Data = DateTime.Parse("30/09/2019 15:43:56"), Usuario = usuario, Sucesso = true},
                new Auditoria { Acao = "Pagamento", Data = DateTime.Parse("30/09/2019 15:45:16"), Usuario = usuario, Sucesso = true}
            };
        }
    }
}
