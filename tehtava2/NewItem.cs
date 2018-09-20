using System;
using System.ComponentModel.DataAnnotations;

namespace tehtava2
{
    public class NewItem
    {
        public string Name { get; set; }

        [Range(1, 99)]
        public int Level {get; set;}

        [ItemTypeValidator]
        public string Type {get; set;}

        [DateTimeValidator]
        [DataType(DataType.Date)]
        public DateTime CreationDate {get; set;}
        
    }
}