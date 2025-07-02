using System.ComponentModel.DataAnnotations;

namespace ApiCrudChallenge.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

    }
}
