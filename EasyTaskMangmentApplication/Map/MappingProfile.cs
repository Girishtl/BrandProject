using AutoMapper;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;
namespace EasyTaskMangmentApplication.Map

{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, UserLoginResponse>();
            CreateMap<UserDTO, UserResponse>();
            CreateMap<CreateUserRequest, UserDTO>();
            CreateMap<UpdateUserRequest, UserDTO>();
            CreateMap<userServiceDTO, userServiceResponse>();
            CreateMap<userServiceCreateRequest, userServiceDTO>();
            CreateMap<userServiceDTO, userServiceResponse>();
            CreateMap<userServiceResponse, userServiceDTO>();
            CreateMap<userServiceCreateRequest, userServiceDTO>();
            CreateMap<userServiceDTO, userServiceCreateRequest>();
            CreateMap<userServiceDTO, userServiceUpdateRequest>();
            CreateMap<userServiceUpdateRequest, userServiceDTO>();
            CreateMap<UserWorkUpdateRequest, UserWorkDetailDTO>();
            CreateMap<UserWorkDetailDTO, UserWorkResponse>();
            CreateMap<UserWorkCreateRequest, UserWorkDetailDTO>();
            CreateMap<LeadDTO,LeadsResponse>();
            CreateMap<LeadsResponse, LeadDTO>();
            CreateMap<MeetingDTO,MeetingResponse>();
            CreateMap<CreateMeetingRequest,MeetingDTO>();
            CreateMap<UpdateMeetingRequest, MeetingDTO>();
            CreateMap<CreateLeadRequest, LeadDTO>();
            CreateMap<UpdateLeadRequest, LeadDTO>();
            
        }
    }
}
