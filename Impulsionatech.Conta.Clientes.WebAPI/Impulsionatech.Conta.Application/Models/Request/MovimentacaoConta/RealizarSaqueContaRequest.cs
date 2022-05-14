using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.MovimentacaoConta
{
    public class RealizarSaqueContaRequest
    {
        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("id_conta")]
        [Range(0, int.MaxValue, ErrorMessage = MensagemUtils.VALOR_INVALIDO)]
        public int IdConta { get; set; }

        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("valor")]
        [Range(0.01, double.MaxValue, ErrorMessage = MensagemUtils.VALOR_INVALIDO)]
        public decimal Valor { get; set; }

    }
}
