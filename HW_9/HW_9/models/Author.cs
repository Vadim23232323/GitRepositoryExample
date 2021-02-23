using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW_9.models
{
    public class Author
    {
        [Key]
        public int AuthorIdentifier { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Description { get; set; }
            public List<Car> Cars { get; set; }

    }
}
