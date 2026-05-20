using AutoMapper;
using Business.DTOs.TaskDto;
using Entity;
using Entity.TaskItemEntity;
using Entity.UserEntity;
using ToDoListApi.Business.Auth;

namespace Business.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TaskItem, ResultTaskDto>().ReverseMap();

        CreateMap<TaskItem, CreateTaskDto>().ReverseMap();

        CreateMap<TaskItem, UpdateTaskDto>().ReverseMap();
        CreateMap<RegisterDTO, User>().ReverseMap();
        CreateMap<LoginDTO, User>().ReverseMap();
    }
}