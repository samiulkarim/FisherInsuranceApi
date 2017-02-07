using Microsoft.AspNetCore.Mvc;

<<<<<<< HEAD
public class LifeController : Controller
=======
namespace FisherInsuranceApi.Controllers
{

[Route("api/Life/quotes")]
 public class LifeController : Controller
 {
>>>>>>> check in

{
    public IActionResult Index()

    {
        return Ok("This is the index of the LifeController");
    }

public IActionResult Quote()

    {
        return Ok("This is the quote of the LifeController");
    }
}