using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/claims")]
 public class ClaimsController : Controller
 {

// POST api/auto/claims
 [HttpPost]
 public IActionResult Post([FromBody] Claim claim)
 {
     var newClaim = db.Claims.Add(claim);
     db.SaveChanges();
     return CreatedAtRoute("GetClaim", new { id = claim.Id }, claim);
 }

// GET api/auto/claims/5
 [HttpGet("{id}", Name = "GetClaim")]
 public IActionResult Get(int id)
 {
   return Ok(db.Claims.Find(id));
 }

 // PUT api/auto/claims/id
 [HttpPut("{id}")]
 public IActionResult Put(int id, [FromBody] Claim claim)
 {
      var newClaim = db.Claims.Find(id);
      if (newClaim == null)
    {
        return NotFound();
    }
    newClaim = claim;
    db.SaveChanges();
    return Ok(newClaim);
 }

// DELETE api/auto/claims/id
 [HttpDelete("{id}")]
 public IActionResult Delete(int id)
 {
 var claimToDelete = db.Claims.Find(id);
 if (claimToDelete == null)
 {
 return NotFound();
 }
 db.Claims.Remove(claimToDelete);
 db.SaveChangesAsync();
 return NoContent();
 }

 private readonly FisherContext db;
public ClaimsController(FisherContext context)
{
 db = context;
} 
[HttpGet]
public IActionResult GetClaims()
{
 return Ok(db.Claims);
}



 }