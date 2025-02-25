using Microsoft.AspNetCore.Mvc;
using ProductsWebAPI.Models;
using ProductsWebAPI.Services;


namespace ProductWebApi.Controller
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _srv;

        public ProductController(IProductService srv)
        {
            this._srv = srv;
        }

        [HttpGet]
        [Route("api/products")]
        public IActionResult GetProduct()
        {
            try
            {
                var products = _srv.GetProducts();
                if (products == null)
                {
                    return NotFound("No products found.");
                }
                return Ok(products);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost("api/insert")]
        public IActionResult Insert([FromBody] Product p)
        {
            try
            {
                bool status=_srv.Insert(p);
                if(status)
                {
                    return Ok("product inserted");
                }
                return BadRequest();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }


        [HttpPut("api/update")]
        public IActionResult Update([FromBody] Product p)
        {
            try
            {
                bool status = _srv.Update(p);
                if (status)
                {
                    return Ok("product updated");
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("api/delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool status=_srv.Delete(id);
                if(status)
                {
                    return Ok("product deleted ");
                }
                return BadRequest();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet("api/getProduct/{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                Product p=_srv.GetProductById(id);
                if(p!=null)
                {
                    return Ok(p);
                }
                else
                {
                    return Ok("Product not found");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest();

            }
        }
    }


   
}