using RestWithASPNET10.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET10.Models
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("title", TypeName = "varchar(max)")]
        public string Title { get; set; }

        [Column("author", TypeName = "varchar(max)")]
        public string Author { get; set; }

        [Column("price", TypeName = "decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }

        [Column("launch_date", TypeName = "datetime2(6)")]
        [Required]
        public DateTime LaunchDate { get; set; }
    }
}
