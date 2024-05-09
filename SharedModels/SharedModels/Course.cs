namespace SharedModels.SharedModels;

public class Course
{
    public int courseId { get; set; }
    public string title { get; set; }
    public string? description { get; set; }
    public int InstructorId { get; set; }
    public User Instructor { get; set; }
}