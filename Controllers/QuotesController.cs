using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;

[Route("api/quotes")]
 public class QuotesController : Controller
 {

// POST api/auto/quotes
 [HttpPost]
 public IActionResult Post([FromBody] Quote quote)
 {
 return Ok(db.CreateQuote(quote)); 
 }

// GET api/auto/quotes/5
 [HttpGet("{id}")]
 public IActionResult Get(int id)
 {
 return Ok(db.RetrieveQuote(id)); 
 }

 // PUT api/auto/quotes/id
 [HttpPut("{id}")]
 public IActionResult Put(int id, [FromBody] Quote quote)
 {
 return Ok(db.UpdateQuote(quote));
 }

// DELETE api/auto/quotes/id
 [HttpDelete("{id}")]
 public IActionResult Delete(int id, [FromBody] Quote quote)
 {
    db.DeleteQuote(id);
    return Ok(); 
 }

 private IMemoryStore db;
public QuotesController(IMemoryStore repo)
{
 db = repo;
} 
[HttpGet]
public IActionResult GetQuotes()
{
 return Ok(db.RetrieveAllQuotes);
}

}