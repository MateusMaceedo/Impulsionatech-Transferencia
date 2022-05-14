using Impulsionatech.Contas.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.Cliente
{
    public class ClienteRequest
    {
        [Required(ErrorMessage = MensagemUtils.CAMPO_OBRIGATORIO)]
        [JsonPropertyName("nome_cliente")]
        [StringLength(100, ErrorMessage = MensagemUtils.TAMANHO_EXCEDIDO)]
        public string Nomecliente { get; set; }

        [Required(ErrorMessage = MensagemUtils.CAMPO_OBRIGATORIO)]
        [Index(IsUnique = true)]
        [ValidaCPFAtributte]
        [JsonPropertyName("cpf")]
        public string NumeroCpf { get; set; }
    }
}
