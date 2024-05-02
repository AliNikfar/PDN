using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application.Exception.Validation
{
    public sealed class ValidationException : Exception.Application.ApplicationException//("Validation Failure","One or more validation errors occurred")
    {

        public ValidationException(IReadOnlyDictionary<string, string[]> errorsDictionary) 
        {
            ErrorsDictionary = errorsDictionary;
        }

        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
    }
}
