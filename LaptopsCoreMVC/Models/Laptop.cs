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


    public class Laptop
    {
        public int LaptopID { get; set; }

        [Required, DisplayName("Price (£)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required, Range(2,32), DisplayName("Ram Size GB")]
        public int RamSize { get; set; }

        [Required, Range(500,2000), DisplayName("HDD Size (GB)")]
        public int MemorySize { get; set; }

        [StringLength(30), DisplayName("Laptop Dimensions (inches)")]
        public string LaptopDimensions { get; set; }

        [Required, StringLength(30), DisplayName("Operating System")]
        public string OperatingSystem { get; set; }

        [Required, StringLength(30), DisplayName("Model")]
        public string Model { get; set; }

        [StringLength(30), DisplayName("Resolution (Pixels)")]
        public string Resolution { get; set; }

        [Required, StringLength(30), DisplayName("Processor")]
        public string Processor { get; set; }

        [Required, Range(1, 12), DisplayName("Battery (hr)")]
        public int BatteryLife { get; set; }

        [DisplayName("Colour")]
        public Colours Colour { get; set; }
        
        [StringLength(2000), DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [StringLength(300), DisplayName("Picture")]
        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }
    }

    public enum Colours 
    {
        Silver,
        Gold, 
        Grey,
        Black,
        Red,
        White,
        Blue,
        Green
    }
}
