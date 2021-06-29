using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDoctors.Models
{
    public class Order
    {
        public int orderid { get; set; }
        public string users { get; set; } // имя фамилия покупателя
        public string address { get; set; } // адрес покупателя
        public string contactphone { get; set; } // контактный телефон покупателя

        public int phoneid { get; set; } // ссылка на связанную модель Phone
        public Phone Phone { get; set; }
    }
}
