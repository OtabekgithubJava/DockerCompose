using Course.Application.Abstraction;
using Course.Application.UseCases.Courses.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using User.Domain.Entities;

namespace Course.Application.UseCases.Courses.Handlers.CommandHandlers;

public class DeleteCourseCommandHandler: IRequestHandler<DeleteCourseCommand, ResponseModel>
{
    private readonly ICourseDbContext _courseDb;

    public DeleteCourseCommandHandler(ICourseDbContext courseDb)
    {
        _courseDb = courseDb;
    }


    public async Task<ResponseModel> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
    {
        var course = await _courseDb.Courses.FirstOrDefaultAsync(x => x.courseId == request.courseId);

        if (course != null)
        {
            _courseDb.Courses.Remove(course);
            await _courseDb.SaveChangesAsync(cancellationToken);

            return new ResponseModel()
            {
                Message = "Deleted Successfully!",
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