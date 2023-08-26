namespace Infinity.Server.Entities;
public class Topic
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string ImagUrl { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public List<User>? Users { get; set; }
    public List<Category>? Childs { get; set; }
    public List<DetailNote>? Notes { get; set; }
    public List<CheatSheet>? CheetSheets { get; set; }
    public List<Exercise>? Exercises { get; set; }
    public Status Status { get; set; } = Status.None;
    public Level Level { get; set; } = Level.VERY_EASY;

}
public enum Level
{
    EXTREMELY_EASY,
    VERY_EASY,
    EASY,
    MODERATE,
    DIFFICULT,
    HARD,
    VERY_HARD,
    EXTREMELY_HARD
}
public enum Status
{
    None,
    Planned,
    InProgress,
    Completed,
    Revised,
    Archived
}