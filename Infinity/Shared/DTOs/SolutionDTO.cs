namespace Infinity.Shared.DTOs;
public class SolutionDTO
{
    public int Id { get; set; }
    public int ExerciseId { get; set; }
    public ExerciseDTO? Exercise { get; set; }
    public string Description { get; set; } = string.Empty;
}