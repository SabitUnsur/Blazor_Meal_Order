using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Text;
using System.ComponentModel.DataAnnotations;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Shared.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreatedUserId { get; set; }

        public Guid SupplierId { get; set; }

<<<<<<< HEAD
        [MinLength(3, ErrorMessage = "Minimum lenght must be 3 characters for Name Field")]
        [StringLength(10)]
        public String Name { get; set; }

        [StringLength(100)]
=======
        public String Name { get; set; }

>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        public String Description { get; set; }

        public DateTime ExpireDate { get; set; }

<<<<<<< HEAD

        public String CreatedUserFullName { get; set; }

        public String SupplierName { get; set; }
=======
        public string CreatedUserFullName { get; set; }
        public string SupplierName { get; set; }

>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
    }
}
