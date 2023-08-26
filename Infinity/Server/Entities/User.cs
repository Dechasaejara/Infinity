namespace Infinity.Server.Entities;
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public List<Topic>? Topics { get; set; }
    public List<Course>? Courses { get; set; }
}