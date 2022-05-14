using Impulsionatech.Contas.Domain.Utils;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.Cliente
{
    public class AtualizarClienteRequest
    {

        [Required(ErrorMessage = MensagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("id_cliente")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = MensagemUtils.CAMPO_OBRIGATORIO)]
        [StringLength(100, ErrorMessage = MensagemUtils.TAMANHO_EXCEDIDO)]
        [JsonPropertyName("id_cliente")]
        public string NomeCliente { get; set; }
    }
}
