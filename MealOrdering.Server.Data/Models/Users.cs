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
    public class Users
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String EMailAddress { get; set; }

        public String Password { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual ICollection<OrderItems> CreatedOrderItems { get; set; }
    }
}
