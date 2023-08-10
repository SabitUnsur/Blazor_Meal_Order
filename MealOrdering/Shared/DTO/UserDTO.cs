using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrdering.Shared.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String EMailAddress { get; set; }

        public String Password { get; set; }

        public bool IsActive { get; set; }

        public string FullName => $"({FirstName} {LastName})";


    }
}
