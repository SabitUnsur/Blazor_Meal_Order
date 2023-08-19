using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Shared.FilterModels
{
    public class OrderListFilterModel
    {
        public DateTime? CreateDateFirst { get; set; }

        public DateTime CreateDateLast { get; set; }

        public Guid CreatedUserId { get; set; }
    }
}
