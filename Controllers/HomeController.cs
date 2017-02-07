using Microsoft.AspNetCore.Mvc;

<<<<<<< HEAD
public class HomeController : Controller
=======
namespace FisherInsuranceApi.Controllers
{

[Route("api/Home/quotes")]
 public class HomeController : Controller
 {

     // POST api/auto/quotes
 [HttpPost]
 public IActionResult Post([FromBody]string value)
 {
 return Created("", value);
 }
>>>>>>> check in

{
    public IActionResult Index()

    {
        return Ok("This is the index of the HomeController");
    }
    
}