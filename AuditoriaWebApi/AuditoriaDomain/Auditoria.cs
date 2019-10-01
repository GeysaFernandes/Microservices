using System;

namespace AuditoriaDomain
{
    public class Auditoria
    {
        public string Acao { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public bool Sucesso { get; set; }
    }
}
