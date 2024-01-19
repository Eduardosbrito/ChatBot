using AutoMapper;
using ChatBot.Models;
using ChatBot_API.Data.DTO;

namespace ChatBot_API.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<ClienteModel, GetClienteContatoDto>();
        CreateMap<ClienteModel, GetClienteEnderecoDto>();
    }
}
