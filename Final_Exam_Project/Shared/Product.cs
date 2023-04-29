using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Project.Shared
{
    public class Product
    {


        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        public string Image { get; set; } = "https://via.placeholder.com/300x300";

        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }


        public bool IsPublic { get; set; }

        public bool IsDeleted { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateModified { get; set; }



    }
}
