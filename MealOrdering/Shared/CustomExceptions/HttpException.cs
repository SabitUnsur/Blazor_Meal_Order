using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Shared.CustomExceptions
{
    public class HttpException : Exception
    {
        public HttpException(String Message) : base(Message) { }

        public HttpException(String Message, Exception InnerException) : base(Message, InnerException) { }
    }
}
