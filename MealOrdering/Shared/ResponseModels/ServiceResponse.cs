using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;

namespace MealOrdering.Shared.ResponseModels
{
    public class ServiceResponse<T>: BaseResponse
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Shared.ResponseModels
{
    public class ServiceResponse<T>:BaseResponse
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
    {
        public T Value { get; set; }
    }
}
