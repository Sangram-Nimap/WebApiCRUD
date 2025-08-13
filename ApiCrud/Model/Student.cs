namespace ApiCrud.Model
{
    public class Student
    {
        public int Id { get; set; } 
        public required  string Name { get; set; }
        public  string? LastName{ get; set; }
        public required String Email { get; set; }

        public string Address { get; set; } = "";
    }
}
