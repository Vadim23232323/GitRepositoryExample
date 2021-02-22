using System;
using System.Collections.Generic;
using System.Text;


namespace HW_9.Attribute
{
    public class Info : System.Attribute
    {
        private string description;

        public int Importance { get; set; }

        public Info(string description)
        {
            this.description = description;
        }
    }
}
