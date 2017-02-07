using Microsoft.AspNetCore.Mvc;

public class HouseController : Controller

{
    public IActionResult Index()

    {
        return Ok("This is the index of the HouseController");
    }

    public IActionResult Quote()

    {
        return Ok("This is the quote of the HouseController");
    }

}