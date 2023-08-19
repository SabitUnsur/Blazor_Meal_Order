using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;

namespace MealOrdering.Shared.CustomExceptions
{
    public class ApiException: Exception
    {

        public ApiException(String Message, Exception InnerException): base(Message, InnerException)
        {

        }

        public ApiException(String Message): base(Message)
        {

        }

=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Shared.CustomExceptions
{
    public class ApiException:Exception
    {
        public ApiException(string message,Exception InnerException):base(message,InnerException)
        {
            
        }


        public ApiException(string message):base(message)
        {
            
        }
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
    }
}
