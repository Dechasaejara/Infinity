namespace Infinity.Server.Entities;
public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImagUrl { get; set; } = string.Empty;
    public List<Topic>? Topics { get; set; }
    public List<User>? Users { get; set; }
    public Status Status { get; set; } = Status.None;
}