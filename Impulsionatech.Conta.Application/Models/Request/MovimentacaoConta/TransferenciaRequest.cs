using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.MovimentacaoConta
{
    public class TransferenciaRequest
    {
        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("id_conta_origem")]
        [Range(0, int.MaxValue, ErrorMessage = MensagemUtils.VALOR_INVALIDO)]
        public int IdContaOrigem { get; set; }

        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("id_conta_destino")]
        [Range(0, int.MaxValue, ErrorMessage = MensagemUtils.VALOR_INVALIDO)]
        public int IdContaDestino { get; set; }

        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("valor")]
        [Range(0.01, double.MaxValue, ErrorMessage = MensagemUtils.VALOR_INVALIDO)]
        public decimal Valor { get; set; }
    }
}
