namespace Infinity.Server.Entities;
public class CheatSheet
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int TopicId { get; set; }
    public Topic? Topic { get; set; }
    public Status Status { get; set; } = Status.None;
    public Level Level { get; set; } = Level.VERY_EASY;
}
