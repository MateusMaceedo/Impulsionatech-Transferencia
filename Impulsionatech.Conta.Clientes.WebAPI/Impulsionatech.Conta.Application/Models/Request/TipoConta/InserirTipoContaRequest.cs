using Impulsionatech.Contas.Domain.Utils;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.TipoConta
{
    public class InserirTipoContaRequest
    {
        [Required(ErrorMessage = MensagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("nome_tipo")]
        [StringLength(50, ErrorMessage = MensagemUtils.TAMANHO_EXCEDIDO)]
        public string NomeTipo { get; set; }
    }
}
