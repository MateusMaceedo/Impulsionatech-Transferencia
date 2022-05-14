using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.Conta
{
    public class ContaRequest
    {
        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("id_tipo_conta")]
        [Range(0, int.MaxValue, ErrorMessage = MensagemUtils.VALOR_INVALIDO)]
        public int IdTipoConta { get; set; }

        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [Range(0, int.MaxValue, ErrorMessage = MensagemUtils.VALOR_INVALIDO)]
        [JsonPropertyName("id_cliente")]
        public int IdCliente { get; set; }

    }
}
