using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace Impulsionatech.Conta.Application.Models.Request.Conta
{
    public class ObterContasPorFiltrosRequest
    {
        [FromQuery]
        [JsonPropertyName("id_conta")]
        public int id_conta { get; set; }

        [FromQuery]
        [JsonPropertyName("cpf")]
        public string Cpf { get; set; }
    }
}
