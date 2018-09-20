using System;
using System.ComponentModel.DataAnnotations;

namespace tehtava2
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [DateTimeValidator]
        public DateTime CreationTime { get; set; }
        [Range(1,99)]
        public int Level { get; set; }
        [ItemTypeValidator]
        public string Type {get; set;}
    }
}