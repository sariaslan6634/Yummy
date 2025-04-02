using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Yummy.Context;
using Yummy.Dtos.ReservationDto;
using Yummy.Entities;

namespace Yummy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IValidator<Reservation> _validator;
        private readonly ApiContext _context;

        public ReservationController(IValidator<Reservation> validator, ApiContext context)
        {
            _validator = validator;
            _context = context;
        }

        [HttpGet]
        public IActionResult ReservationList()
        {
            var value = _context.Reservations.ToList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateReservation(Reservation reservation)
        {
            var validationResult = _validator.Validate(reservation);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            else
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                return Ok("Rezervasyon işlemi başarılı");
            }
        }

        [HttpPut]
        public IActionResult UpdateReservation(Reservation reservation)
        {
            var validationResult = _validator.Validate(reservation);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            else
            {
                _context.Reservations.Update(reservation);
                _context.SaveChanges();
                return Ok("Rezervasyon güncelleme işlemi başarılı");
            }
        }

        [HttpPut("UpdateReservationAktiveAndPassive")]
        public IActionResult UpdateReservationAktiveAndPassive(UpdateReservationAktiveAndPassiveDto updateReservationAktiveAndPassiveDto)
        {
            var value = _context.Reservations.Where(x => x.ReservationId == updateReservationAktiveAndPassiveDto.ReservationId).FirstOrDefault();
            if (value.ReservationStatus == "1")
            {
                value.ReservationStatus = "0";
                _context.Reservations.Update(value);
                _context.SaveChanges();
                return Ok("Rezervasyon işlemi PASİF yapıldı");
            }
            else
            {
                value.ReservationStatus = "1";
                _context.Reservations.Update(value);
                _context.SaveChanges();
                return Ok("Rezervasyon işlemi AKTİF yapıldı");
            }
        }



    }
}
