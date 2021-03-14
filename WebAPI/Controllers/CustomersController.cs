using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("add")]
        public IActionResult AddCustomer(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteCustomer(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetCustomers()
        {
            var result = _customerService.GetCustomers();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getcustomerdetails")]
        public IActionResult Getdetails()
        {
            var result = _customerService.GetCustomerDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
