using Course.Application.Abstraction;
using Course.Application.UseCases.Courses.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using User.Domain.Entities;

namespace Course.Application.UseCases.Courses.Handlers.CommandHandlers;

public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, ResponseModel>
{
    private readonly ICourseDbContext _courseDb;

    public UpdateCourseCommandHandler(ICourseDbContext courseDb)
    {
        _courseDb = courseDb;
    }

    public async Task<ResponseModel> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = await _courseDb.Courses.FirstOrDefaultAsync(x => x.courseId == request.courseId);

        if (course != null)
        {
            course.title = request.title;
            course.description = request.description;
            course.InstructorId = request.InstructorId;
            course.Instructor = request.Instructor;

            _courseDb.Courses.Update(course);
            _courseDb.SaveChangesAsync(cancellationToken);

            return new ResponseModel()
            {
                Message = "Updated Successfully!",
                StatusCode = 201
            };
        }

        return new ResponseModel()
        {
            Message = "N/A Course",
            StatusCode = 400
        };
    }
}