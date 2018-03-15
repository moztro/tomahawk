using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using tomahawk.domain.products.Enums;

namespace tomahawk.domain.products
{
    [Table("Beverages")]
    public class Beverage
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        /// <summary>
        /// Beverage capacity (ml)
        /// </summary>
        public double Capacity { get; set; }

        public BeveragePresentation Presentation { get; set; }

        public BeverageType Type { get; set; }
    }
}
