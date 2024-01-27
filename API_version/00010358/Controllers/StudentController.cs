using _00010358.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;


namespace _00010358.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        //adding an instance of book repository which enables interacting with DB
        public StudentController(IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository; 
        }

        // GET: api/Student

        /// <summary>
        /// Returns a list of students
        /// </summary>
        /// <returns> A list of students</returns>
        /// <remarks>
        /// 
        /// Sample request
        /// GET /api/Student
        /// </remarks>
        /// <response code="200">Returns a list of students</response>
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public IActionResult Get()
        {
            //getting student from repository using GetStudents method
            var stu = _studentRepository.GetStudents();
            return new OkObjectResult(stu);
        }

        // GET: api/Student/5
        /// <summary>
        /// Get a single student
        /// </summary>
        /// <param name="id">Request's payload</param>
        /// <response code="200">Returned single student successfully</response>
        [HttpGet("{id}", Name = "Get")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Find))]
        public IActionResult Get(int id)
        {
            //getting single student from repository using GetById method
            var product = _studentRepository.GetById(id);
            return new OkObjectResult(product);
        }

        // POST: api/Student 

        /// <summary>
        /// Create a new student
        /// </summary>
        /// <param name="student">Request body</param>
        /// <response code="200">Student added successfully</response>
        /// 
        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        public IActionResult Post([FromBody] Student student) 
        { 
            using (var scope = new TransactionScope()) 
            {
                //inseting single student from repository using insert method
                _studentRepository.Insert(student); 
                scope.Complete(); 
                return CreatedAtAction(nameof(Get), new { id = student.StudentID }, student);
            } 
        }

        // PUT: api/Student/5
        /// <summary>
        /// Updates a student
        /// </summary>
        /// <param name="id">Pass id of student want to update</param>
        /// <param name="student">Request body</param>
        /// <response code="200">Student updated successfully</response>
        [HttpPut("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Edit))]
        public IActionResult Put(int id, [FromBody]Student student)         
        {             
            if (student != null)             
            {                 
                using (var scope = new TransactionScope())                
                {

                    //updating single student from repository using Update method
                    _studentRepository.Update(student);                    
                    scope.Complete();                    
                    return new OkResult();                
                }            
            }             
            return new NoContentResult();        
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Delete student from database
        /// </summary>
        /// <param name="id">Pass id of student want to delete</param>
        /// <response code="200">Student deleted successfully</response>
        [HttpDelete("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Delete))]
        public IActionResult Delete(int id)         
        {
            //deleting single student from repository using Delete method
            _studentRepository.Delete(id);             
            return new OkResult();        
        }
    }
}
