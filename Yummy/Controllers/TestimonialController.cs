using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Context;
using Yummy.Entities;

namespace Yummy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IValidator<Testimonial> _validator;
        private readonly IMapper _mapper;
        public TestimonialController(IMapper mapper, ApiContext context, IValidator<Testimonial> validator)
        {
            _mapper = mapper;
            _context = context;
            _validator = validator;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _context.Testimonial.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            var validationResult = _validator.Validate(testimonial);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            else
            {
                _context.Testimonial.Add(testimonial);
                _context.SaveChanges();
                return Ok("Referans ekleme işlemi başarılı");
            }
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonial.Where(x => x.TestimonialId == id).FirstOrDefault();
            _context.Testimonial.Remove(value);
            _context.SaveChanges();
            return Ok("Referans silme işlemi başarılı");
        }

        [HttpGet("GetByIdTestimonial")]
        public IActionResult GetByIdTestimonial(int id)
        {
            return Ok(_context.Testimonial.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var validationResult = _validator.Validate(testimonial);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            else
            {
                _context.Testimonial.Update(testimonial);
                _context.SaveChanges();
                return Ok("Referans güncelleme işlemi başarılı");
            }
        }

    }
}
