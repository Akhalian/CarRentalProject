using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : Controller
    {
        private IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("add")]
        public IActionResult AddCar(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteCar(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateCar(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetRentals()
        {
            var result = _rentalService.GetRentals();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getdetails")]
        public IActionResult GetRentaldetails()
        {
            var result = _rentalService.GetRentDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
