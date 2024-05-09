using Course.Application.UseCases.Courses.Commands;
using Course.Application.UseCases.Courses.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Admin.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly IMediator _mediator;

    public CourseController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<ActionResult> CreateCourse(CreateCourseCommand command)
    {
        var result = await _mediator.Send(command);
        
        return Ok(result);
    }
    
    
    [HttpGet]
    public async Task<ActionResult<List<SharedModels.SharedModels.Course>>> GetAllAdmins()
    {
        var result = await _mediator.Send(new GetAllCourseQuery());

        return Ok(result);
    }
    
    
    [HttpPut]
    public async Task<ActionResult> UpdateAdmin(UpdateCourseCommand command)
    {
        var result = await _mediator.Send(command);

        return Ok(result);
    }


    [HttpDelete]
    public async Task<ActionResult> DeleteAdmin(DeleteCourseCommand command)
    {
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}