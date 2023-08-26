namespace Infinity.Server.Entities;
public class Exercise
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int TopicId { get; set; }
    public Topic? Topic { get; set; }
    public Status Status { get; set; } = Status.None;
    public Level Level { get; set; } = Level.VERY_EASY;
    public List<Solution>? Solutions { get; set; }
}