using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Context;
using Yummy.Entities;

namespace Yummy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiContext _context;

        public CategoriesController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _context.Categories.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Kategori ekleme işlemi başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("Kategori silme işlemi başarılı");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var values = _context.Categories.Find(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
