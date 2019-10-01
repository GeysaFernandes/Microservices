using System;

namespace AuditoriaWebApi.Dto
{
    public class AuditoriaDto
    {
        public string Acao { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public bool Sucesso { get; set; }
    }
}
