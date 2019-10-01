using System;

namespace LivrariaWebApi.Dto
{
    public class LivrariaDto
    {
        public string Acao { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public bool Sucesso { get; set; }
    }
}
