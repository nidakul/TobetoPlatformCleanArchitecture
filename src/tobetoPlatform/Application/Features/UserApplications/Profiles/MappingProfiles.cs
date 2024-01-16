using Application.Features.UserApplications.Commands.Create;
using Application.Features.UserApplications.Commands.Delete;
using Application.Features.UserApplications.Commands.Update;
using Application.Features.UserApplications.Queries.GetById;
using Application.Features.UserApplications.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.UserApplications.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<UserApplication, CreateUserApplicationCommand>().ReverseMap();
        CreateMap<UserApplication, CreatedUserApplicationResponse>().ReverseMap();
        CreateMap<UserApplication, UpdateUserApplicationCommand>().ReverseMap();
        CreateMap<UserApplication, UpdatedUserApplicationResponse>().ReverseMap();
        CreateMap<UserApplication, DeleteUserApplicationCommand>().ReverseMap();
        CreateMap<UserApplication, DeletedUserApplicationResponse>().ReverseMap();
        CreateMap<UserApplication, GetByIdUserApplicationResponse>()
                                                 .ForMember(dest => dest.ApplicationStepName,
                                                 opt => opt.MapFrom(src => src.ApplicationSteps.Select(step => step.Name).FirstOrDefault()))
                                                 .ReverseMap();
        CreateMap<UserApplication, GetListUserApplicationListItemDto>()
                                                 .ForMember(dest => dest.ApplicationStepName,
                                                 opt => opt.MapFrom(src => src.ApplicationSteps.Select(step => step.Name).ToList()))
                                                 .ReverseMap();
        CreateMap<IPaginate<UserApplication>, GetListResponse<GetListUserApplicationListItemDto>>().ReverseMap();
    }
}