using System.ComponentModel.DataAnnotations;

namespace ApiCrudChallenge.Dtos
{
    public class CustomerDto
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

    }
}
