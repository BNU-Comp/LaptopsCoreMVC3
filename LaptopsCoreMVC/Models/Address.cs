using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{
    /// <summary>
    /// Christian
    /// </summary>
    public class Address
    {
        public int AddressID { get; set; }
        [Required, Range(1, 20)]
        public string HouseNumber { get; set; }
        [Required, Range(1, 30)]
        public string Street { get; set; }
        [Required, StringLength(9)]
        public string Postcode { get; set; }
        [Required, Range(1, 30)]
        public string City { get; set; }
        [Required, Range(1, 30)]
        public Counties Country { get; set; }

    }


    public enum Counties
    {
        Bucks,
        Herts,
        Middlesex,
        Essex
    }
}
