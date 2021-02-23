using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;


namespace HW_9.models
{
    public class Car
        {
            public int Id { get; set; }

            [Required]
            public string CarName { get; set; }
            [Required]
            public string ModelName { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            public int AuthorID { get; set; }
            public Author Author { get; set; }

    }
    }
