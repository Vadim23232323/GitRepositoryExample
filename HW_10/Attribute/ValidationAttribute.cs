using System;
using System.Collections.Generic;
using System.Text;

namespace HW_9.Attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ValidationAttribute : System.Attribute
    {
        private int _importance { get; set; } = 0;

        public string Description { get; set; }

        public ValidationAttribute()
        { }

        public ValidationAttribute(int importance)
        {
            _importance = importance;
        }
    }
}
