using AutoMapper;
using PDN.Application.Queries.Tasks.GetAll;
using PDN.Domain.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = PDN.Domain.Entities.Tasks.Task;

namespace PDN.Application.Mapper
{
    public  class TaskDTOProfile : Profile
    {
        public TaskDTOProfile()
        {
            CreateMap<GetAllTasksDTO,Task>().ReverseMap();
            CreateMap<List<GetAllTasksDTO>,List <Task>>().ReverseMap();
        }
    }
}
