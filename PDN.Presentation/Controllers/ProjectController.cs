using MediatR;
using Microsoft.AspNetCore.Mvc;
using PDN.Application.Commands.Projects.Create;
using PDN.Application.Commands.Projects.Delete;
using PDN.Application.Commands.Projects.Update;
using PDN.Application.Queries.Projects.GetAll;
using PDN.Application.Queries.Projects.GetById;

namespace PDN.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator ;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(nameof(Get))]
        public async Task<GetProjectDTO> Get([FromQuery]GetProjectQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<GetAllProjectsDTO>> GetAll([FromQuery] GetAllProjectsQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        public async Task<long> Create(CreateProjectCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut]
        public async Task<long> Update(UpdateProjectCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete]
        public async Task Delete(DeleteProjectCommand command)
        {
            await _mediator.Send(command);
        }
    }
}
