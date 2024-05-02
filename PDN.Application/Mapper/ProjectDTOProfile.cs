using AutoMapper;
using PDN.Application.Queries.Projects.GetAll;
using PDN.Domain.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Mapper
{
    public class ProjectDTOProfile : Profile
    {
        public ProjectDTOProfile()
        {
            CreateMap<GetAllProjectsDTO, Project>().ReverseMap();
            CreateMap<List<GetAllProjectsDTO>,List<Project>>().ReverseMap();
        }
    }
}
