using integraApi.Dtos;
using integraApi.interfaces;
using integraApi.Model;
using integraApi.Models;

namespace integraApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public Task<ResponseGenerico<BancoModel>> BuscarBancoPeloCodigo(string CodigoBanco)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseGenerico<CepModel>> BuscarEnderecoPorCep(string Cep)
        {
            var Request = new HttpRequestMessage(HttpMethod.Get, " $ https://brasilapi.com.br/api/cep/v1/{Cep}");
            var response = new ResponseGenerico<CepModel>();
            using (var Client = new HttpClient())
            {
                var ResponseBrasilApi= await Client.SendAsync(Request);
                var ContentResponse=await ResponseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = jsonDeserialize
            }
        }


        public Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
    }
}
