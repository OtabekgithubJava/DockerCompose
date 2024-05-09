namespace SharedModels.SharedModels;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public int Age { get; set; }
    
    public ICollection<Course> Courses { get; set; }
}