namespace Infinity.Shared.DTOs;
public class CourseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImagUrl { get; set; } = string.Empty;
    public List<TopicDTO>? Topics { get; set; }
    public List<UserDTO>? Users { get; set; }
    public Status Status { get; set; } = Status.None;
}