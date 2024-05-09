using Course.Domain.Entities;
using MediatR;

namespace Course.Application.UseCases.Courses.Commands;

public class UpdateCourseCommand : IRequest<ResponseModel>, IRequest<User.Domain.Entities.ResponseModel>
{
    public int courseId { get; set; }
    public string title { get; set; }
    public string? description { get; set; }
    public int InstructorId { get; set; }
    public SharedModels.SharedModels.User Instructor { get; set; }
}