using MediatR;
using Microsoft.AspNetCore.Mvc;
using PDN.Application.Commands.Task.Create;
using PDN.Application.Commands.Task.Delete;
using PDN.Application.Commands.Task.Update;
using PDN.Application.Queries.Tasks.GetAll;
using PDN.Application.Queries.Tasks.GetById;

namespace PDN.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController: ControllerBase
    {
        private readonly IMediator _mediator ;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(nameof(Get))]
        public async Task<GetTaskDTO> Get([FromQuery] GetTaskQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<GetAllTasksDTO>> GetAll([FromQuery] GetAllTaskQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        public async Task<long> Create(CreateTaskCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut]
        public async Task<long> Update(UpdateTaskCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete]
        public async Task Delete(DeleteTaskCommand command)
        {
            await _mediator.Send(command);
        }
    }
}
