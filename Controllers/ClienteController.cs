using AutoMapper;
using ChatBot.Data;
using ChatBot_API.Data.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private ClienteContext _context;
    private IMapper _mapper;

    public ClienteController(ClienteContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("Endereco/{cpf}")]
    public IActionResult PegarEnderecoClientePorCPF(string cpf)
    {
        if (cpf.Length != 11)
            return NotFound($"CPF: {cpf} Incorreto, com apenas {cpf.Length} caracteres, tem que ter 11 caracteres.");

        var clientes = _mapper.Map<GetClienteEnderecoDto>(_context.Cliente.FirstOrDefault(x => x.Cpf.Equals(cpf)));

        if (clientes == null)
            return NotFound($"Cliente com CPF {cpf} não encontrado.");

        return Ok(clientes);
    }
}
