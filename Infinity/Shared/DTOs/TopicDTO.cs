namespace Infinity.Shared.DTOs;
public class TopicDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string ImagUrl { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public CategoryDTO? Category { get; set; }
    public List<UserDTO>? Users { get; set; }
    public List<CategoryDTO>? Childs { get; set; }
    public List<DetailNoteDTO>? Notes { get; set; }
    public List<CheatSheetDTO>? CheetSheets { get; set; }
    public List<ExerciseDTO>? Exercises { get; set; }
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