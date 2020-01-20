using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{
    /// <summary>
    /// Luke
    /// </summary>
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        public int LaptopID { get; set; }

        public int OrderID { get; set; }

        [Required, DisplayName("Price (£)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        // Navigation

        public Laptop Laptop { get; set; }

        public Order Order { get; set; }
    }
}
