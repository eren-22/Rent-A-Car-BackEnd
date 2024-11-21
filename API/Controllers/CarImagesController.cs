using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _carImageService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Add")]
        public IActionResult Add(CarImage carImage)
        {
            var result = _carImageService.Add(carImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Update")]
        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageService.Update(carImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
