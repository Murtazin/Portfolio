using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Controllers;

public class DataBaseController : Controller
{
    private readonly ApplicationContext _db;

    public DataBaseController(ApplicationContext db)
    {
        _db = db;
    }
}