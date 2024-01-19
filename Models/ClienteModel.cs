using System.ComponentModel.DataAnnotations;

namespace ChatBot.Models;

public class ClienteModel
{
    [Key]
    [Required]
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    [Required(ErrorMessage = "O CPF é Obrigatorio.")]
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Sexo { get; set; }
    public string Signo { get; set; }
    public string NomeMae { get; set; }
    public string NomePai { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Cep { get; set; }
    public string Endereco { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string TelefoneFixo { get; set; }
    public string TelefoneCelular { get; set; }
    public decimal Altura { get; set; }
    public int? Peso { get; set; }
    public string TipoSanguineo { get; set; }
    public DateTime DataCadastro { get; set; }
}
