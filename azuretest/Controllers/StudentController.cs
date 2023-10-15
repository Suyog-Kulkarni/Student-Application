using azuretest.Data;
using azuretest.Models;
using Microsoft.AspNetCore.Mvc;

namespace azuretest.Controllers;
public class StudentController : Controller
{
    private readonly StudentDbContext _context;

    public StudentController(StudentDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        IEnumerable<Student> objList = _context.Students.ToList();
        return View(objList);
    }

    public IActionResult AddStudent()
    {
        return View();
    }// one to show to view and another to send data to database 
    // both have same name but different methods
    // and works on same view
    [HttpPost]
    public IActionResult AddStudent(Student obj)
    {
        if (ModelState.IsValid)
        {
            _context.Students.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        return View(obj);
    }
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if(id is null or 0)
        {
            return NotFound();
        }
        var studentFromDb = _context.Students.FirstOrDefault(u => u.ID == id);

        return View(studentFromDb);
    }

    [HttpPost]
    public IActionResult Edit(Student obj)
    {
        if (ModelState.IsValid)
        {
            _context.Students.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id is null or 0)
        {
            return NotFound();
        }

        var studentFromDb = _context.Students.Find(id);

        if (studentFromDb is null)
        {
            return NotFound();
        }
        return View(studentFromDb);
    }

    /*[HttpPost, ActionName("Delete")]
    public IActionResult DeleteStudent(int? id)
    {

        var studentFromDb = _context.Students.Find(id);

        if(studentFromDb is null)
        {
            return NotFound();
        }
        _context.Students.Remove(studentFromDb);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }*/
    [HttpPost]
    public IActionResult Delete(Student obj)
    {

        var studentFromDb = _context.Students.FirstOrDefault(u => u.ID==obj.ID);

        if (studentFromDb is null)
        {
            return NotFound();
        }
        _context.Students.Remove(studentFromDb);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}

