using System.Text.Json.Serialization;

namespace integraApi.Dtos
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }

        public string? Nome { get; set; }

        public long? Codigo { get; set; }

        public string? NomeCompleto { get; set; }
    }
}
