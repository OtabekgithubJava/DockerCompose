using Course.Application.Abstraction;
using Course.Application.UseCases.Courses.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Course.Application.UseCases.Courses.Handlers.QueryHandlers
{
    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCourseQuery, List<SharedModels.SharedModels.Course>>
    {
        private readonly ICourseDbContext _courseDb;

        public GetAllCoursesQueryHandler(ICourseDbContext courseDb)
        {
            _courseDb = courseDb;
        }

        public async Task<List<SharedModels.SharedModels.Course>> Handle(GetAllCourseQuery request,
            CancellationToken cancellationToken)
        {
            return await _courseDb.Courses.ToListAsync(cancellationToken);
        }
    }
}
