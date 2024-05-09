using Course.Domain.Entities;
using MediatR;

namespace Course.Application.UseCases.Courses.Commands;

public class CreateCourseCommand : IRequest<ResponseModel>
{
    public string title { get; set; }
    public string? description { get; set; }
    public int InstructorId { get; set; }
    public SharedModels.SharedModels.User Instructor { get; set; }
}