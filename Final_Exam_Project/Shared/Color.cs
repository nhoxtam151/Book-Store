using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Final_Exam_Project.Shared
{
    public class Color
    {

        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

    }
}
