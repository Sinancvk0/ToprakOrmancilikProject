using Bussiness.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
[AllowAnonymous]
public class ProductController : Controller
{
    private readonly IProductService _db;

    public ProductController(IProductService db)
    {
        _db = db;
    }

    public IActionResult Index(int id)
    {
        var detail = _db.TGetById(id);
        if (detail == null)
        {
            return NotFound();
        }

        return View(detail);
    }
}
