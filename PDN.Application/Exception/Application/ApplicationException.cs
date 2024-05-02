using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PDN.Application.Exception.Application
{
    public abstract class ApplicationException : System.Exception
    {
        public ApplicationException()
        {
            
        }
        protected ApplicationException(string title, string message)
            : base(message) =>
            Title = title;

        public string Title { get; }
    }
}
