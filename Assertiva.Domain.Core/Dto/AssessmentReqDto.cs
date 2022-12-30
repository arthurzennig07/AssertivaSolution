using Assertiva.Domain.Core;

namespace Assertiva.Domain.Dto;

public class AssessmentReqDto
{
    public User User { get; set; }
    public Bateria Bateria { get; set; }
    public IEnumerable<Escolha> Escolhas { get; set; }
    public bool? HasMood { get; set; }
    public Mood Mood { get; set; }
}