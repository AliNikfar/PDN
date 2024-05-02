using PDN.Domain.Entities.Projects;
using PDN.Domain.Entities.Teams;
using PDN.Shared.Abstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Domain.Entities.Tasks
{
    public class Task : BaseEntity<long>
    {

        public Task(string title, string description, DateTime dueDate, TaskStatus status, long projectId)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Status = status;
            ProjectId = projectId;

        }
        public string Title { get; private set; } 

        public string Description { get; private set; } 

        public DateTime DueDate { get; private set; } 

        public TaskStatus Status { get; private set; } 

        public long ProjectId { get; private set; } 

        public Project Project { get; private set; }

        public Team Team { get; private set; }

        public void Update(string title, string description, DateTime dueDate, TaskStatus status)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Status = status;
        }
}
}
