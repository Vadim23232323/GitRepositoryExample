using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8.models
{
    public class Author
    {
        public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Description { get; set; }
            public List<Car> Cars { get; set; }

    }
}
