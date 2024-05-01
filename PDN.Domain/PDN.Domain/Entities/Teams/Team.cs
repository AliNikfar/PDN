using PDN.Shared.Abstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Domain.Entities.Teams
{
    public class Team : BaseEntity<long>
    {
        public Team(string firstName, string lastName, string email, long taskId, PDN.Domain.Entities.Tasks.Task task)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            TaskId = taskId;
            Task = task;
        }
        public Team()
        { 
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public long TaskId { get; set; }

        public PDN.Domain.Entities.Tasks.Task Task { get; set; }
    }
}
