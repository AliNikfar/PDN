using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Shared.Abstraction.Entities
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }

        public bool IsDeleted { get; set; }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
