using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Final_Exam_Project.Shared
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product Product { get; set; }

        public int ProductId { get; set; }

        public Color Color { get; set; }

        public int ColorId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

    }
}
