using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalDoctors.Models;

namespace PersonalDoctors
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.phones.Any())
            {
                context.phones.AddRange(
                    new Phone
                    {
                        name = "iPhone X",
                        company = "Apple",
                        price = 600
                    },
                    new Phone
                    {
                        name = "Samsung Galaxy Edge",
                        company = "Samsung",
                        price = 550
                    },
                    new Phone
                    {
                        name = "Pixel 3",
                        company = "Google",
                        price = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
