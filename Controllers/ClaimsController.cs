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
 return Ok(db.CreateClaim(claim));
 }

// GET api/auto/claims/5
 [HttpGet("{id}")]
 public IActionResult Get(int id)
 {
 return Ok(db.RetrieveClaim(id));
 }

 // PUT api/auto/claims/id
 [HttpPut("{id}")]
 public IActionResult Put(int id, [FromBody] Claim claim)
 {
 return Ok(db.UpdateClaim(claim));
 }

// DELETE api/auto/claims/id
 [HttpDelete("{id}")]
 public IActionResult Delete(int id, [FromBody] Claim claim)
 {
    db.DeleteClaim(id);
    return Ok(); 
 }

 private IMemoryStore db;
public ClaimsController(IMemoryStore repo)
{
 db = repo;
} 
[HttpGet]
public IActionResult GetClaims()
{
 return Ok(db.RetrieveAllClaims);
}

 }