using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace integraApi.Mappings
{
    public class CepMapping : Profile
    {
        public CepMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), Typeof(ResponseGenerico<>));
            CreateMap<CepResponse, CepModel>();
            CreateMap<CeModel, CepResponse>();

        }
    }
    
}
