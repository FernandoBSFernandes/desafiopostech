using System.ComponentModel.DataAnnotations;

namespace MainWebAPI.DbContextConfig
{
    public class Power
    {
        [Key]
        public int Id { get; set; } 

        public string Power_Name { get; set; }
    }
}