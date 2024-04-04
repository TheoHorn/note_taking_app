using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using note_taking_app.Data;
using note_taking_app.Models;

namespace note_taking_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var notes = _context.Note.ToList();
        if (notes.Count == 0)
        {
            return View();
        }
        var one_note = notes[0];
        var noteView = new NoteView(one_note);
        return View(noteView);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
