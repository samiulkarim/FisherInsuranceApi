using Microsoft.AspNetCore.Mvc;

namespace FisherInsuranceApi.Controllers
{

<<<<<<< HEAD
    [Route("api/auto/claims")]
=======
[Route("api/customer/claims")]
>>>>>>> check in
 public class ClaimsController : Controller
 {

     // POST api/auto/claims
 [HttpPost]
 public IActionResult Post([FromBody]string value)
 {
 return Created("", value);
 }

 // GET api/auto/claims/5
 [HttpGet("{id}")]
 public IActionResult Get(int id)
 {
 return Ok("The id is: " + id);
 }

 // PUT api/auto/claims/id
 [HttpPut("{id}")]
 public IActionResult Put(int id, [FromBody]string value)
 {
 return NoContent();
 }

// DELETE api/auto/claims/id
 [HttpDelete("{id}")]
 public IActionResult Delete(int id)
 {
 return Delete(id);
 }
 
 }

}