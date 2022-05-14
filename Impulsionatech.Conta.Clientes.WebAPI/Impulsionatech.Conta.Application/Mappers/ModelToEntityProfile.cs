using System;
using System.Collections.Generic;
using System.Text;

namespace Impulsionatech.Conta.Application.Mappers
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<InserirTipoContaRequest, TipoContaEntity>();

            CreateMap<ContaRequest, ContaEntity>();

            CreateMap<AtualizarStatusContaRequest, ContaEntity>();

            CreateMap<RealizarDepositoContaRequest, MovimentacaoContaEntity>();

            CreateMap<RealizarSaqueContaRequest, MovimentacaoContaEntity>();

            CreateMap<ClienteRequest, ClienteEntity>().ForMember(src => src.NumeroCpf, dest => dest.MapFrom(opt => opt.NumeroCpf.RetornaSomenteNumeros()));

            CreateMap<AtualizarClienteRequest, ClienteEntity>();

            CreateMap<ContaRequest, ContaEntity>().ForMember(src => src.Status, dest => dest.MapFrom(opt => new { Status = "A" }.Status));
        }
    }
}
