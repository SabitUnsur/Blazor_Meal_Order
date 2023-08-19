using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Server.Data.Models
{
    public class Orders
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreatedUserId { get; set; }

        public Guid SupplierId { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public DateTime ExpireDate { get; set; }


        public virtual Users CreatedUser { get; set; }

        public virtual Suppliers Supplier { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
    }
}
