using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiCrudChallenge.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required  string Name { get; set; }
    }
}
