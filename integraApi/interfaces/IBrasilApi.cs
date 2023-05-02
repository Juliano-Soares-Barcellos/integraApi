
using integraApi.Dtos;
using integraApi.Model;
using integraApi.Models;

namespace integraApi.interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<CepModel>> BuscarEnderecoPorCep(String Cep);
        Task <ResponseGenerico<List<BancoModel>>>BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBancoPeloCodigo(String CodigoBanco);
    }
}
