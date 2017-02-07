using Microsoft.AspNetCore.Mvc;

[Route("api/customer/claims")]
 public class ClaimsController : Controller
 {

// POST api/Customer/claims
 [HttpPost]
 public IActionResult Post([FromBody]string value)
 {
 return Created("", value);
 }

// GET api/Customer/claims/5
 [HttpGet("{id}")]
 public IActionResult Get(int id)
 {
 return Ok("The id is: " + id);
 }

 // PUT api/Customer/claims/id
 [HttpPut("{id}")]
 public IActionResult Put(int id, [FromBody]string value)
 {
 return NoContent();
 }

// DELETE api/Customer/claims/id
 [HttpDelete("{id}")]
 public IActionResult Delete(int id)
 {
 return Delete(id);
 }

 }