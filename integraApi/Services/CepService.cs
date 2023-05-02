using ICepService;

namespace integraApi.Service
    
{
    public class CepService : ICepService
    {
        private readonly  IMapper _mapper;
        private readonly IBrasilApi _BrasilApi;


        public CepService(IMapper mapper,IBrasil brasil)
        {
            _mapper = mapper;
            _BrasilApi = brasii;
        }

       public Task<ResponseGenerico<CepModel>> BuscarEndereco(String cep)
        {
            var Cep = await _brasilApi.BuscarEndereco(cep);
            return mapper.Map<ResponseGenerico<CepResponse>>(Cep);
        }

    }
}
