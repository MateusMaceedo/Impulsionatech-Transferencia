using System;
using System.Collections.Generic;
using System.Text;

namespace Impulsionatech.Conta.Application.Mappers
{
    public class EntityToModelProfile : Profile
    {
        public EntityToModelProfile()
        {
            CreateMap<TipoContaEntity, TipoContaResponse>();

            CreateMap<ContaEntity, ContaResponse>();

            CreateMap<MovimentacaoContaEntity, MovimentacaoContaResponse>();

            CreateMap<ClienteEntity, ClienteResponse>().ForMerber(src => src.NumeroCpf, dest => dest.MapFrom(opt => opt.NumeroCpf.FormatCPF()));

            CreateMap<ContaEntity, ContaResponse>();

            CreateMap<ContaEntity, InserirContaResponse>();
        }
    }
}
