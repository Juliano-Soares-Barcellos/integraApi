using System.Text.Json.Serialization;

namespace integraApi.Dtos
{
    public class CepResponse
    {
        public string? estado { get; set; }

        public string? cidade { get; set; }

        public string? regiao { get; set; }

        public string? rua { get; set; }

        public string? servico { get; set; }
    }
}
