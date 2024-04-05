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
        var tasks = _context.Task.ToList();
        var files = _context.File.ToList();
        foreach (var note in notes)
        {
            note.setTasks(tasks.Where(t => t.IdNote == note.Id).ToList());
            foreach (var task in note.Tasks)
            {
                task.NoteTitle = note.Title;
            }
            note.Files = files.Where(f => f.IdNote == note.Id).ToList();
        }
        var globalView = new GlobalView(notes);
        return View(globalView);
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
