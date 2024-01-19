using System.ComponentModel.DataAnnotations;

namespace ChatBot_API.Data.DTO;

public class GetClienteContatoDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string TelefoneFixo { get; set; }
    public string TelefoneCelular { get; set; }
}
