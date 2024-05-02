using PDN.Shared.Abstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDN.Domain.Entities.Projects
{
    public class Project : BaseEntity<long>
    {
    


        public Project(string title, string description, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Title { get; private set; }

        public string Description { get; private set; } 

        public DateTime StartDate { get; private set; } 

        public DateTime EndDate { get; private set; } 

        public ICollection<PDN.Domain.Entities.Tasks.Task> Tasks { get; private set; }

        public void Update(string title, string description, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
