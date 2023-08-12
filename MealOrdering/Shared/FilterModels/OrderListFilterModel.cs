using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Shared.FilterModels
{
    public class OrderListFilterModel
    {
        public DateTime? CreateDateFirst { get; set; }

        public DateTime CreateDateLast { get; set; }

        public Guid CreatedUserId { get; set; }
    }
}
