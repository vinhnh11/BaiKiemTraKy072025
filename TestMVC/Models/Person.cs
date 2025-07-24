using System.ComponentModel.DataAnnotations;
namespace TestMVC.Models
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string Fullname { get; set; }
        public string DiaChi { get; set; }
    }
}