﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _rentalService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
