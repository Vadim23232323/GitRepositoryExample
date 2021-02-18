using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8.models
{
    public class Car
        {
            public int Id { get; set; }
            public string CarName { get; set; }
            public string ModelName { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            public int AuthorID { get; set; }
            public Author Author { get; set; }

    }
    }
