using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrrencyException : ApplicationException
    {
        public DbConcurrrencyException(string message) : base(message) { }
    }
}
