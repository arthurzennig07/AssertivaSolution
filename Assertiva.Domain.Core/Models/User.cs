namespace Assertiva.Domain.Core;

public class User
{
    public int UserId { get; set; }
    public string Uuid { get; set; }
    public int FaixaEtaria { get; set; }
    public int Sexo { get; set; }
    public DateTime Datacriacao { get; set; }
    public string Modelo { get; set; }
    public string Versao { get; set; }
    public string Email { get; set; }
}