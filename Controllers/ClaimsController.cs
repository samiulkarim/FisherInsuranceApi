using Microsoft.AspNetCore.Mvc; 
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;

[Route("api/claims")] 
public class ClaimsController : Controller 

{
    // POST api/auto/Claims 
   [HttpPost] 
   public IActionResult Post([FromBody] Claim claim) 
   { 
       var newClaim = db.Claims.Add(claim); 
       db.SaveChanges(); 
       return CreatedAtRoute("GetClaim", new { id = claim.Id }, claim); }

     // GET api/auto/Claims/5 
    [HttpGet] 
     public IActionResult GetClaims() 
    {
        return Ok(db.Claims); }

     [HttpGet("{id}", Name = "GetClaim")] 
     public IActionResult Get(int id) 
     {
          return Ok(db.Claims.Find(id)); }

    // PUT api/auto/Claims/id 
   [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Claim claim) 
    { 
        var newClaim = db.Claims.Find(id); 
        if (newClaim == null) { return NotFound(); } 
        newClaim = claim; db.SaveChanges(); return Ok(newClaim);
    }

    // DELETE api/auto/Claims/id
    [HttpDelete("{id}")] 
    public IActionResult Delete(int id) 
    {
         var claimToDelete = db.Claims.Find(id); 
         if (claimToDelete == null) { return NotFound(); } 
         db.Claims.Remove(claimToDelete); 
         db.SaveChangesAsync(); 
         return NoContent();}
    private readonly FisherContext db;
    public ClaimsController(FisherContext context)
    {
    db = context;
    }  
}