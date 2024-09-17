using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Pizza.WisniewskiStudio.Model;
using Pizza.WisniewskiStudio.Dane;

namespace Pizza.WisniewskiStudio.Kontroler;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}