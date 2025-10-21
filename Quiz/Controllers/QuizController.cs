using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace QuizApp.Controllers
{[ApiController]
[Route("api/[controller]")]
public class QuizController : ControllerBase
{
    private static readonly List<Quiz> quizzes = new List<Quiz>
    {
        new Quiz("What is the capital of France?", new List<string>{"Paris","London","Berlin","Madrid"}, "Paris"),
        new Quiz("What is the capital of England?", new List<string>{"Paris","London","Berlin","Madrid"}, "London")
    };

    [HttpGet]
    public IActionResult GetAllQuestions()
        {
            return Ok(quizzes);
        }

    [HttpGet("rand")]
    public IActionResult GetRandomQuestion()
    {
        if (quizzes.Count == 0) return NotFound();
        return Ok(quizzes[Random.Shared.Next(quizzes.Count)]);
    }
}









}


