using integraApi.Dtos;
using integraApi.interfaces;
using integraApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using System.Text.Jason;

namespace integraApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
     
        public async Task<ResponseGenerico<CepModel>> BuscarEnderecoPorCep(string Cep)
        {
            var Request = new HttpRequestMessage(HttpMethod.Get, " $ https://brasilapi.com.br/api/cep/v1/{Cep}");
            var response = new ResponseGenerico<CepModel>();
            using (var Client = new HttpClient())
            {
                var ResponseBrasilApi= await Client.SendAsync(Request);
                var ContentResponse=await ResponseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerealizer.Deserealize<CepModel>(ContentResponse);

                if (ResponseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = ResponseBrasilApi.statusCode;
                    response.DadosRetorno = bjsResponse;
                }
                else
                {
                    response.CodigoHttp = response.StatusCode;
                    response.ErroRetorno = JasonSerializer.Deserialize<ExpandoObject>(ContentResponse);
                }
            }
        }
        public Task<ResponseGenerico<BancoModel>> BuscarBancoPeloCodigo(string CodigoBanco)
        {
            throw new NotImplementedException();
        }


        public Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
    }
}
