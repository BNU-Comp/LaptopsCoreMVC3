using LaptopsCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Data
{
    public static class DbInitialiser
    {
        public static void DbInitialise(ApplicationDbContext context)
        {
            InitialiseCustomers(context);
            InitialiseLaptops(context);
           // InitialiseAddresses(context);
           // IntialisePayments(context);
        }

        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            if (context.Addresses.Any())
            {
                return;
            }

            var addresses = new Address[]
            {
                new Address
                {
                    HouseNumber = "38",
                    Street = "High Street",
                    City = "Watford",
                    Country = Counties.Bucks,
                    Postcode = "WD5 0EL"
                }
            };

        }

        private static void IntialisePayments(ApplicationDbContext context)
        {
           
        }

        private static void InitialiseLaptops(ApplicationDbContext context)
        {
            if (context.Laptop.Any())
            {
                return;
            }

            var laptops = new Laptop[]
            {
                new Laptop
                {
                    Model = "HP",
                    Colour = Colours.Blue,
                    LaptopDimensions = "15x16x13",
                    BatteryLife = 8,
                    MemorySize = 500,
                    OperatingSystem = "Windows 10",
                    RamSize = 8,
                    Processor = "Intel Core m",
                    Resolution = "1920 x 1080",
                    Price = 500,
                    //Picture = "https://store.hp.com/UKStore/Html/Merch/Images/c06224213_1750x1285.jpg",
                    Description = "Thin and Sleek: With its brushed finish and seamless bar hinge, the smartly designed HP laptop looks as good as it performs."

                },
                new Laptop
                {
                    Model = "Macintosh",
                    Colour = Colours.Grey,
                    LaptopDimensions = "13x12x14",
                    BatteryLife = 7,
                    MemorySize = 400,
                    OperatingSystem = "Mac OS X",
                    RamSize = 8,
                    Processor = "8-core Intel",
                    Resolution = "1920 x 1080",
                    Price = 600,
                    //Picture = "https://images.techhive.com/images/article/2014/12/macbook_air-100538062-large.jpg",
                    Description = "The Macintosh is carved out of solid aluminum, thus giving it a distinctive look and a grayish-white hue. The Macintosh in particular has a thin and light design."

                },

                new Laptop
                {
                    Model = "Windows",
                    Colour = Colours.Gold,
                    LaptopDimensions = "11x14x15",
                    BatteryLife = 9,
                    MemorySize = 600,
                    OperatingSystem = "Windows 10",
                    RamSize = 8,
                    Processor = "Core i5",
                    Resolution = "1920 x 1080",
                    Price = 800,
                    Picture = "Windows.png",
                    Description = "A smooth all-metal finish gives this laptop a sharp, polished look - from the elevated keyboard to the new narrow bezel design, every detail was crafted for comfort and style."
                },

                new Laptop
                {
                    Model = "Asus",
                    Colour = Colours.Silver,
                    LaptopDimensions = "13x16x11",
                    BatteryLife = 6,
                    MemorySize = 300,
                    OperatingSystem = "Intel Celeron N4000",
                    RamSize = 4,
                    Processor = "Intel 4th Gen Core",
                    Resolution = "1920 x 1080",
                    Price = 400,
                    //Picture = "https://images-na.ssl-images-amazon.com/images/I/71VDl54D8pL._SX466_.jpg",
                    Description = "A smooth all-metal finish gives this laptop a sharp, polished look - from the elevated keyboard to the new narrow bezel design, every detail was crafted for comfort and style."

                },

                new Laptop
                {
                    Model = "Dell",
                    Colour = Colours.Black,
                    LaptopDimensions = "13x16x11",
                    BatteryLife = 10,
                    MemorySize = 700,
                    OperatingSystem = "Windows 8",
                    RamSize = 8,
                    Processor = "intel pentium 3",
                    Resolution = "1920 x 1080",
                    Price = 400,
                    //Picture = "https://images-na.ssl-images-amazon.com/images/I/71VDl54D8pL._SX466_.jpg",
                    Description = "A smooth all-metal finish gives this laptop a sharp, polished look - from the elevated keyboard to the new narrow bezel design, every detail was crafted for comfort and style."

                },

                new Laptop
                {
                    Model = "Lenovo",
                    Colour = Colours.Grey,
                    LaptopDimensions = "13x16x11",
                    BatteryLife = 13,
                    MemorySize = 700,
                    OperatingSystem = "Windows 10",
                    RamSize = 8,
                    Processor = "intel core i7",
                    Resolution = "1920 x 1080",
                    Price = 900,
                    //Picture = "Lenova.png",
                    Description = "A smooth all-metal finish gives this laptop a sharp, polished look - from the elevated keyboard to the new narrow bezel design, every detail was crafted for comfort and style."

                },

                new Laptop
                {
                    Model = "MSI",
                    Colour = Colours.Red,
                    LaptopDimensions = "12x17x13",
                    BatteryLife = 12,
                    MemorySize = 600,
                    OperatingSystem = "Windows 8",
                    RamSize = 16,
                    Processor = "intel core i7",
                    Resolution = "1920 x 1080",
                    Price = 900,
                    //Picture = "https://static.bhphotovideo.com/explora/sites/default/files/MSI_0.jpg",
                    //Picture = "MSI Laptop",
                    Description = "A smooth all-metal finish gives this laptop a sharp, polished look - from the elevated keyboard to the new narrow bezel design, every detail was crafted for comfort and style."

                },


                new Laptop
                {
                    Model = "Acer",
                    Colour = Colours.White,
                    LaptopDimensions = "11x15x12",
                    BatteryLife = 9,
                    MemorySize = 700,
                    OperatingSystem = "Windows 10",
                    RamSize = 16,
                    Processor = "Intel Core i5-4210U",
                    Resolution = "1920 x 1080",
                    Price = 1100,
                    //Picture = "https://static.bhphotovideo.com/explora/sites/default/files/Acer-Aspire.jpg",
                    //Picture = "MS Laptop",
                    Description = "A smooth all-metal finish gives this laptop a sharp, polished look - from the elevated keyboard to the new narrow bezel design, every detail was crafted for comfort and style."

                },

                new Laptop
                {
                    Model = "Macbook",
                    Colour = Colours.Grey,
                    LaptopDimensions = "12x13x19",
                    BatteryLife = 10,
                    MemorySize = 800,
                    OperatingSystem = "Mac OS X",
                    RamSize = 16,
                    Processor = "8-core Intel",
                    Resolution = "1920 x 1080",
                    Price = 1100,
                    //Picture = "https://cdn.pocket-lint.com/r/s/970x/assets/images/71784-laptops-review-apple-macbook-pro-15-inch-i5-notebook-image1-yjlcOnqg4Z.JPG",
                    //Picture = "MS Laptop",
                    Description = "The Macintosh is carved out of solid aluminum, thus giving it a distinctive look and a grayish-white hue. The Macintosh in particular has a thin and light design."

                },

                new Laptop
                {
                    Model = "HP",
                    Colour = Colours.Blue,
                    LaptopDimensions = "13x15x16",
                    BatteryLife = 12,
                    MemorySize = 900,
                    OperatingSystem = "Microsoft 10",
                    RamSize = 16,
                    Processor = "Intel Core i5",
                    Resolution = "1920 x 1080",
                    Price = 1100,
                    //Picture = "https://johnlewis.scene7.com/is/image/JohnLewis/238340601?$rsp-pdp-port-1080$",
                    //Picture = "MS Laptop",
                    Description = "Microsoft laptop with high end specifications."

                }

            };

            foreach (Laptop l in laptops)
            {
                context.Laptop.Add(l);
            }

            context.SaveChanges();
        }

        private static void InitialiseCustomers(ApplicationDbContext context)
        {
            if(context.Customers.Any())
            {
                return;
            }

            var customers = new Customer[]
            {
                new Customer
                {
                    FirstName = "John",
                    LastName = "Smith",
                    EmailAddress = "Customer1@gmail.com",
                    PhoneNumber = "01639526487"


                },

                new Customer
                {
                    FirstName = "Mike",
                    LastName = "Johnson",
                    EmailAddress = "Customer2@gmail.com",
                    PhoneNumber = "01689576487"


                },

                new Customer
                {
                    FirstName = "Richard",
                    LastName = "Jones",
                    EmailAddress = "Customer3@gmail.com",
                    PhoneNumber = "01689573287"


                },

                new Customer
                {
                    FirstName = "Terry",
                    LastName = "Philips",
                    EmailAddress = "Customer4@gmail.com",
                    PhoneNumber = "01689576492"


                },

                new Customer
                {
                    FirstName = "Justin",
                    LastName = "Johnson",
                    EmailAddress = "Customer5@gmail.com",
                    PhoneNumber = "01689176487"


                },

                new Customer
                {
                    FirstName = "Johnny",
                    LastName = "Lazar",
                    EmailAddress = "Customer6@gmail.com",
                    PhoneNumber = "01689139587"


                },

                new Customer
                {
                    FirstName = "Jon",
                    LastName = "Bones",
                    EmailAddress = "Customer7@gmail.com",
                    PhoneNumber = "01689176403"


                },
                
                new Customer
                {
                    FirstName = "Jenny",
                    LastName = "Robertson",
                    EmailAddress = "Customer8@gmail.com",
                    PhoneNumber = "01680576487"


                },

                new Customer
                {
                    FirstName = "Rick",
                    LastName = "Johnson",
                    EmailAddress = "Customer9@gmail.com",
                    PhoneNumber = "01689173387"


                },
                
                new Customer
                {
                    FirstName = "Michael",
                    LastName = "Williams",
                    EmailAddress = "Customer10@gmail.com",
                    PhoneNumber = "01689176487"


                },

            };

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }

            context.SaveChanges();

        }
    }
}
