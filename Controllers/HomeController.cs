using Microsoft.AspNetCore.Mvc;

[Route("api/Home/quotes")]
 public class HomeController : Controller
 {

// POST api/Home/quotes
 [HttpPost]
 public IActionResult Post([FromBody]string value)
 {
 return Created("", value);
 }

// GET api/Home/quotes/5
 [HttpGet("{id}")]
 public IActionResult Get(int id)
 {
 return Ok("The id is: " + id);
 }

 // PUT api/Home/quotes/id
 [HttpPut("{id}")]
 public IActionResult Put(int id, [FromBody]string value)
 {
 return NoContent();
 }

// DELETE api/Home/quotes/id
 [HttpDelete("{id}")]
 public IActionResult Delete(int id)
 {
 return Delete(id);
 }

 }