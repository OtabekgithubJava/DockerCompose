namespace SharedModels.SharedModels;

public class Progress
{
    public int ProgressId { get; set; }
    public int UserId { get; set; }
    public int CourseId { get; set; }
    public List<int> CompletedLessons { get; set; }
    public List<int> CompletedQuizzes { get; set; }
    public int OverallProgress { get; set; }
}