using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_26_Commerce.Data;
using Lab_26_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_26_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private Lab26DBContext _dbContext { get; set; }
        public CategoriesController(Lab26DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        public async Task<ActionResult> CreateCategory(string Name, string Description)
        {
            Category category = new Category(Name, Description);
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = _dbContext.Categories.ToList();
            return categories;
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteCategories(int CategoryId) 
        {
            var categoryToDelete = await _dbContext.Categories.FindAsync(CategoryId);
            _dbContext.Categories.Remove(categoryToDelete);
            return Ok();
        }
    }
}
