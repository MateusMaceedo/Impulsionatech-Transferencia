using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.Conta
{
    public class AtualizarStatusContaRequest
    {
        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("id_conta")]
        public int IdConta { get; set; }

        [Required(ErrorMessage = MessagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("status")]
        public StatusContaEnum Status { get; set; }
    }
}
