using Champions_League.Data;
using Champions_League.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Champions_League.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class CLController : ControllerBase
    {
        private readonly CLDbContext _dbContext;
        public CLController(CLDbContext CLContext)
        {
            _dbContext = CLContext;
        }

        [HttpGet("hello", Name = "Hello")]
        public string Hello()
        {
            string hostName = System.Net.Dns.GetHostName();
            StringBuilder sb = new StringBuilder();
            foreach (var adr in System.Net.Dns.GetHostEntry(hostName).AddressList)
                sb.Append($"Adress: {adr.AddressFamily} {adr.ToString()}\n");
            return $"Hello from host: {hostName}\n{sb.ToString()}";
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<ChampionsLeagueVinnere>>> GetChampionsLeagueVinnereAsync()
        {
            return Ok(await _dbContext.ChampionsLeague.ToListAsync());
        }
    }
}