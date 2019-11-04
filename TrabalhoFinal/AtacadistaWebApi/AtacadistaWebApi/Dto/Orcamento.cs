using System;

namespace AtacadistaWebApi.Dto
{
    public class Orcamento
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
