using mission10API_fairbanks.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mission10API_fairbanks.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private readonly BowlerDbContext _bowlerContext;  // ✅ Correct field

        public BowlerController(BowlerDbContext temp)
        {
            _bowlerContext = temp;  // ✅ Correctly assigns temp to the field
        }

        [HttpGet(Name = "GetBowler")]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var bowlerList = await _bowlerContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team != null &&
                            (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .Select(b => new
                {
                    BowlerID = b.BowlerID,
                    FirstName = b.BowlerFirstName ?? "",
                    MiddleInit = b.BowlerMiddleInit ?? "",
                    LastName = b.BowlerLastName ?? "",
                    TeamName = b.Team!.TeamName ?? "",
                    Address = b.BowlerAddress ?? "",
                    City = b.BowlerCity ?? "",
                    State = b.BowlerState ?? "",
                    Zip = b.BowlerZip ?? "",
                    PhoneNumber = b.BowlerPhoneNumber ?? ""
                })
                .ToListAsync();

            return Ok(bowlerList);
        }
    }
}
