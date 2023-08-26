namespace Infinity.Shared.DTOs;
public class UserDTO
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public List<TopicDTO>? Topics { get; set; }
    public List<CourseDTO>? Courses { get; set; }
}