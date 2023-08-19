using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Shared.DTO
{
    public class OrderItemsDTO
    {
        public Guid Id { get; set; }
<<<<<<< HEAD

        public DateTime CreateDate { get; set; }

        public Guid CreatedUserId { get; set; }

        public Guid OrderId { get; set; }

        public String Description { get; set; }


        public String CreatedUserFullName { get; set; }

        public String OrderName { get; set; }
=======
        public DateTime CreateDate { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid OrderId { get; set; }
        public String Description { get; set; }
        public String CreatedUserFullName { get; set; }
        public String OrderName { get; set; }

>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
    }
}
