using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole {
    public class EmployeeRoleProfile : Profile {
        public EmployeeRoleProfile() {
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDto, 
                Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("RoleName", opt => opt.MapFrom(src => src.Cargo)); //For constructor Parameter

            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, Dtos.EmployeeRole.EmployeeRoleDto>()
                .ForMember(dest => dest.Idenficador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.RoleName))
                .ForAllOtherMembers(i => i.Ignore());
        }
    }
}
