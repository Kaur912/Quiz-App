using System.Collections.Generic;

namespace QuizApp.Models
{
    public class Quiz
    {
        public string? Question { get; set; }
        public List<string> Options { get; set; }
        public string? Answer { get; set; }

        public Quiz(string question, List<string> options, string answer)
        {
            Question = question;
            Options = options;
            Answer = answer;
        }
    }
}

