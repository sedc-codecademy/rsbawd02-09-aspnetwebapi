using Microsoft.AspNetCore.Mvc;

namespace NotesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public StudentsController() { }

        // URL: http://mywebapp.com/api/notes
        [HttpGet]
        public ActionResult<string[]> Get()
        {
           return new string[] { "Milica", "Tamara" };
        }

        [HttpGet("getAllStudents")]
        public ActionResult<string[]> Students() 
        {
            // HttpResponse response =  studentskiServis.DajMiStudente();

            return new string[] { "Milica 2", "Tamara 2" };
        }

        [HttpGet("getStudentById/{id}/grade/{grade}")]
        public ActionResult<string> GetById(int id, int grade) 
        {
            if (id == 1)
                return "Tamara " + grade;

            if (id == 2)
                return "Milica " + grade;

            return "Other student";
        }
    }
}
