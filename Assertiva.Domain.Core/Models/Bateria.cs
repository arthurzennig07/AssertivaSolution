using System;

namespace Assertiva.Domain.Core;

public class Bateria
{
    public int BateriaId { get; set; }
    public int UserId { get; set; }
    public DateTime Data { get; set; }
    public DateTime DataFinalizacao { get; set; }
    public int Acertos { get; set; } 
    public int Duracao { get; set; }
    public int Classe { get; set; }
    public int Finalizado { get; set; }
    public int Circadiano { get; set; }
    public int Dificuldade { get; set; }
    
    //Classe =  1*(1+ idxFaixaEtaria) + 50*(1 + idxSexo)
}