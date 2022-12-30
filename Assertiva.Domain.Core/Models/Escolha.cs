using System.Text.Json.Serialization;

namespace Assertiva.Domain.Core;

public class Escolha
{
    
    public long EscolhaId { get; set; }
    public int FigCerta { get; set; } //todo: fazer objeto/modelo para Figura
    [JsonPropertyName("figII")]
    public int? Fig2 { get; set; }
    [JsonPropertyName("figIII")]
    public int? Fig3 { get; set; }
    [JsonPropertyName("escolha")]
    public int Escolhido { get; set; } //todo: fazer objeto para Alternativa
    [JsonPropertyName("alternativaII")]
    public int Alternativa2 { get; set; }
    [JsonPropertyName("alternativaIII")]
    public int Alternativa3 { get; set; }
    public int Duracao { get; set; }
    public int Etapa { get; set; }
    public int BateriaId { get; set; }
    public int Decorrido { get; set; }

    // public Figura FCerta => new Figura(FigCerta);

}
// (1 * posicao + 10 * cor + 100 * tamanho + 1000 * geometria) *figCerta
public class Figura
{
    
    public Posicao ScreenPositionId { get; set; }
    public Colors ColorId { get; set; }
    public int GeometryId { get; set; }
    public bool IsCorrectChoice { get; set; }
    
    public Figura ToFigura(int val)
    {
        string strVal = "";
        if (val > -300 && val < 300 ) 
        {strVal = val.ToString();}
        else
        {
            throw new ArgumentOutOfRangeException($"Integer for Figure must be between -300 and +300 and non null. Cannot parse folowing value:=> {val}. \n");
        }

        var digitArray = strVal.ToCharArray();
        ScreenPositionId = (Posicao)Int32.Parse(digitArray[0].ToString());
        ColorId = (Colors) Int32.Parse(digitArray[1].ToString());
        return null;
    }
    
    public enum Colors
    {
        Vermelho =1,
        Roxo = 2,
        Azul = 3,
        Verde = 4,
        Amarelo = 5,
        Laranja = 6,
        Cinza = 7,
        Preto = 8
    }

    public enum Geometria
    {
        Quadrado = 0,
        Triangulo = 1,
        Circulo = 2
    }

    public enum Posicao
    {
        EsqTopo = 0, //Esquerda Topo / top left
        EsqMeio = 1,
        EsqBaix = 2,
        CenTopo = 3,
        CenMeio = 4, // Centro Meio / middle middle
        CenBaix = 5,
        DirTopo = 6,
        DirMeio = 7,
        DirBaixo = 8 // Direita Baixo/ bottom right
    }

    
}


//(1 * palavra + 1000 * cor + 10000 * ordem) * altCerta;
public class Alternativa
{
    public int Word { get; set; }
    public int ColorId { get; set; }
    public int Order { get; set; }
    public bool IsCorrectChoice { get; set; }
}