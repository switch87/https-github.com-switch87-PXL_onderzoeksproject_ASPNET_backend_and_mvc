namespace MvcApplication.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? BirthDate { get; set; }
        public int? Death { get; set; }
        public char Sex { get; set; }
        public string Origin { get; set; }
        public string Allegiance { get; set; }
    }
}