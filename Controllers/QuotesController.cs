using Microsoft.AspNetCore.Mvc; 
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/quotes")] 
public class QuotesController : Controller {

 [HttpPost] 
   public IActionResult Post([FromBody] Quote Quote) 
   { 
       var newQuote = db.Quotes.Add(Quote); 
       db.SaveChanges(); 
       return CreatedAtRoute("GetQuote", new { id = Quote.Id }, Quote); }

     // GET api/auto/Quotes/5 
    [HttpGet] 
     public IActionResult GetQuotes() 
    {
        return Ok(db.Quotes); }

     [HttpGet("{id}", Name = "GetQuote")] 
     public IActionResult Get(int id) 
     {
          return Ok(db.Quotes.Find(id)); }

    // PUT api/auto/Quotes/id 
   [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Quote Quote) 
    { 
        var newQuote = db.Quotes.Find(id); 
        if (newQuote == null) { return NotFound(); } 
        newQuote = Quote; db.SaveChanges(); return Ok(newQuote);
    }

    // DELETE api/auto/Quotes/id
    [HttpDelete("{id}")] 
    public IActionResult Delete(int id) 
    {
         var QuoteToDelete = db.Quotes.Find(id); 
         if (QuoteToDelete == null) { return NotFound(); } 
         db.Quotes.Remove(QuoteToDelete); 
         db.SaveChangesAsync(); 
         return NoContent();}

    private readonly FisherContext db;
    public QuotesController(FisherContext context)
    {
    db = context;
    }
}