using AutoMapper;
using Domain.Dtos;
using Domain.Entities;


namespace Infrastructure.AutoMapper;

public class InfrastructureProfile:Profile
{
    public InfrastructureProfile()
    {
        CreateMap<GetEmployeeDto, Employee>().ReverseMap();
    }
}