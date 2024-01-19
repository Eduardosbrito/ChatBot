using System.ComponentModel.DataAnnotations;

namespace ChatBot_API.Data.DTO;

public class GetClienteEnderecoDto
{
    public string Nome { get; set; }
    public string Cep { get; set; }
    public string Endereco { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
}
