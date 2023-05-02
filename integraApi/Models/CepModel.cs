using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace integraApi.Models
{
    public class CepModel
    {
        [JsonPropertyName("cep")]
        
        public long? Cep { get; set; }

        [JsonPropertyName("state")]
        public string? estado { get; set; }

        [JsonPropertyName("city")]
        public string? cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? regiao { get; set; }

        [JsonPropertyName("street")]
        public string? rua { get; set; }

        [JsonPropertyName("service")]
        public string? servico { get; set; }

    }
}
