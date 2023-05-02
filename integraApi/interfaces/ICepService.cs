namespace integraApi.interfaces
{
    public interface ICepService
    {
        Task<ResponseGenerico<CepResponse>> BuscarEndereco(String cep);
    }
}
