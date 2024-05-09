using Course.Domain.Entities;
using MediatR;

namespace Course.Application.UseCases.Courses.Commands;

public class DeleteCourseCommand : IRequest<ResponseModel>, IRequest<User.Domain.Entities.ResponseModel>
{
    public int courseId { get; set; }
}