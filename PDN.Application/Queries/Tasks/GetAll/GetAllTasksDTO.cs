using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Queries.Tasks.GetAll
{
    public record GetAllTasksDTO
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TaskStatus Status { get; set; }

        public long ProjectId { get; set; }
    }
}
