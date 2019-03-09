using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        public QuestionsController()
        {
            
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


        [HttpPost]
        public void Post( [FromBody] Question model)
        {

        }
    }
}