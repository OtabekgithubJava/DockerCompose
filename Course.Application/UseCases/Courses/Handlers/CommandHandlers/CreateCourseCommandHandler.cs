using Course.Application.Abstraction;
using Course.Application.UseCases.Courses.Commands;
using Course.Domain.Entities;
using MediatR;

namespace Course.Application.UseCases.Courses.Handlers.CommandHandlers;

public class CreateCourseCommandHandler: IRequestHandler<CreateCourseCommand, ResponseModel>
{
    private readonly ICourseDbContext _courseDb;

    public CreateCourseCommandHandler(ICourseDbContext courseDb)
    {
        _courseDb = courseDb;
    }

    public async Task<ResponseModel> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        if (request != null)
        {
            var course = new SharedModels.SharedModels.Course()
            {
                title = request.title,
                description = request.description,
                InstructorId = request.InstructorId,
                Instructor = request.Instructor
            };

            await _courseDb.Courses.AddAsync(course);
            await _courseDb.SaveChangesAsync(cancellationToken);

            return new ResponseModel()
            {
                Message = "Course Created Successfully!",
                StatusCode = 201
            };
        }

        return new ResponseModel()
        {
            Message = "Failed to Create a Course!",
            StatusCode = 400
        };
    }
    
}