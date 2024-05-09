using MediatR;

namespace Course.Application.UseCases.Courses.Queries;

public class GetAllCourseQuery : IRequest<List<SharedModels.SharedModels.Course>>
{
    
}