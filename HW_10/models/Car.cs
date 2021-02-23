using System;
using System.Collections.Generic;
using System.Text;
using HW_9.Attribute;

namespace HW_9.models
{
    [Info("This is attributes example class", Importance = 42)]
    public class Car
    {
        [Info("key")]
        public int Id { get; set; }
        [Info("name car")]
        public string CarName { get; set; }
        [Info("Model car")]
        public string ModelName { get; set; }
        [Info("Color car")]
        public string Color { get; set; }
        [Info("Age car")]
        public int Age { get; set; }

    }
}
