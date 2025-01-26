using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class Fruit
    {
        public int ID { get; set; }

        [DisplayName("Fruit Name")]
        public string Name { get; set; }

        [DisplayName("Sale Price")]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }
        /// <summary>
        /// Must be between 0 and 1
        /// </summary>
        [DisplayName("Store Percentage")]
        public decimal StoreCutPercentage { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Total Profit")]
        [DataType(DataType.Currency)]
        public decimal Profit
        {
            get
            {
                return (Quantity * SalePrice) - (StoreCutPercentage * (Quantity * SalePrice));
            }
        }

        [DisplayName("Profit Per Item")]
        [DataType(DataType.Currency)]
        public decimal ProfitPerItem
        {
            get
            {
                return SalePrice - (StoreCutPercentage * SalePrice);
            }
        }
    }
}
