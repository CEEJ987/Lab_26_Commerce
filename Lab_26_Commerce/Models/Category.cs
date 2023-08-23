using Microsoft.AspNetCore.Identity;

namespace Lab_26_Commerce.Models
{
    public class Category

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category(string name, string description)
        {
        }
    }
}
