using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;

namespace MealOrdering.Server.Data.Models
{
    public class OrderItems
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreatedUserId { get; set; }

        public Guid OrderId { get; set; }

        public String Description { get; set; }


=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Server.Data.Models
{
    //Orders --> Select Pizza
    //OrderItems --> Pepperoni,Margarita ?
    public  class OrderItems
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid OrderId { get; set; }
        public String Description { get; set; }
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        public virtual Users CreatedUser { get; set; }
        public virtual Orders Order { get; set; }
    }
}
