using SecretariaConcafras.Domain.Enums;

namespace SecretariaConcafras.Domain.Entities
{
    public class Pagamento
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid InscricaoId { get; set; }
        public Inscricao Inscricao { get; set; }

        public decimal Valor { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        // Status controlado pelo retorno do PagSeguro
        public StatusPagamento Status { get; set; } = StatusPagamento.Pendente;

        // Informa��es de transa��o no PagSeguro
        public string? CodigoTransacao { get; set; }
        public string? MetodoPagamento { get; set; } // PIX, Cart�o, Boleto
        public string? QrCodePix { get; set; } // quando for PIX

        // Hist�rico de altera��es
        public ICollection<PagamentoHistorico> Historicos { get; set; } = new List<PagamentoHistorico>();
    }
}
