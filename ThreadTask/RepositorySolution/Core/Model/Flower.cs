using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class Flower
    {
        public int ID { get; set; }

        [DisplayName("Flower Name")]
        public string Name { get; set; }

        [DisplayName("Sale Price")]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }

        [DisplayName("Unit Price")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Profit")]
        [DataType(DataType.Currency)]
        public decimal Profit
        {
            get
            {
                return (SalePrice * Quantity) - (UnitPrice * Quantity);
            }
        }
    }
}
