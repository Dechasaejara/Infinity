namespace Infinity.Shared.DTOs;
public class ExerciseDTO
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int TopicId { get; set; }
    public TopicDTO? Topic { get; set; }
    public Status Status { get; set; } = Status.None;
    public Level Level { get; set; } = Level.VERY_EASY;
    public List<SolutionDTO>? Solutions { get; set; }
}