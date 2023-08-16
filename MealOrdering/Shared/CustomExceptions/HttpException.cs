using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Shared.CustomExceptions
{
    public class HttpException : Exception
    {
        public HttpException(String Message) : base(Message) { }

        public HttpException(String Message, Exception InnerException) : base(Message, InnerException) { }
    }
}
