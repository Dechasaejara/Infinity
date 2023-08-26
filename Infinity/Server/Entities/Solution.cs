namespace Infinity.Server.Entities;
public class Solution
{
    public int Id { get; set; }
    public int ExerciseId { get; set; }
    public Exercise? Exercise { get; set; }
    public string Description { get; set; } = string.Empty;
}