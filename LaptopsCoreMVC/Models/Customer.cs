using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{

    /// <summary>
    /// Alexis
    /// </summary>

    public class Customer
    {
        public int CustomerID { get; set; }

        public string UserID { get;  set; }

        [Required, StringLength(20), DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(20), DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(20), DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required, StringLength(20), DisplayName("Phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        
        public Nullable<int> AddressID { get; set; }
    }
}
