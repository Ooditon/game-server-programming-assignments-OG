using System.ComponentModel.DataAnnotations;

namespace tehtava2
{
    public class NewPlayer
    {
        public string Name { get; set; }
        [Range(1, 99)]
        public int Level { get; set; }
        public string Tag { get; set; }
        }
}