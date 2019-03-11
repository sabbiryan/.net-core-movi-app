using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly QuizContext _context;

        public QuestionsController(QuizContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Question> Get()
        {
            return new List<Question>()
            {
                new Question(){Text = "Question 1"},
                new Question() { Text = "Question 2"}
            };
        }


        [Authorize]
        [HttpPost]
        public void Post( [FromBody] Question model)
        {
            var userId = HttpContext.User.Claims.First().Value;
            model.UserId = userId;

            _context.Questions.Add(model);
                  
            _context.SaveChanges();
        }
    }
}