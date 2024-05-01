using PDN.Domain.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Mapper
{
    public  class TaskDTOProfile : Profile
    {
        public TaskDTOProfile()
        {
            CreateMap<GetAllTaskDTO, Task>().ReverseMap();
        }
    }
}
}
