using ApiCrudChallenge.Data;
using ApiCrudChallenge.Dtos;
using ApiCrudChallenge.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrudChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbConnection _context;

        public CustomerController(AppDbConnection context)
        {
            this._context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllData()
        {
            var customer = _context.Customers.ToList();
            return Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult> AddAndUpDate(CustomerDto customerDto)
        {
            var updateCustomer = await _context.Customers.FindAsync(customerDto.Id);
                if (updateCustomer != null)
            {
                updateCustomer.Id = customerDto.Id;
                updateCustomer.Name = customerDto.Name;
                updateCustomer.Email = customerDto.Email;

                _context.SaveChanges();
                return Ok(updateCustomer);

            }
            var addCustomer = new Customer()
            {
                Name = customerDto.Name,
                Email = customerDto.Email,

            };
          await  _context.Customers.AddAsync(addCustomer);
            _context.SaveChanges();
            return Ok(addCustomer);


        }


        [HttpDelete("{id}")]
        public  async Task<IActionResult> DeleteCustomer(int id )
        {
            var customer =  await _context.Customers.FindAsync(id);
            if (customer is null)
            {
                return NotFound();
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return Ok(customer);


        }


    }
}
