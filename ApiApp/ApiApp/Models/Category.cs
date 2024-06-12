using System.ComponentModel.DataAnnotations;

namespace ApiApp.Models
{
    public class Category :BaseEntity
    {
        [StringLength(10)]
        public string Name { get; set; }
    }
}
