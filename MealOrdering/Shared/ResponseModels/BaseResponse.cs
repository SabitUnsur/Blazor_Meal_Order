using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Shared.ResponseModels
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Success = true;
        }

        public bool Success { get; set; }
<<<<<<< HEAD

        public String Message { get; set; }

        public void SetException(Exception Exception)
        {
            Success = false;
            Message = Exception.Message;
=======
        public string Message { get; set; }

        public void SetException(Exception exception)
        {
            Success = false;
            Message = exception.Message;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        }

    }
}
