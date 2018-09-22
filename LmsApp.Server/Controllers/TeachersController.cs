using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;
using Model.Repo;
using RequestModel;

namespace LmsApp.Server.Controllers
{
    [Produces("application/json")]
    [Route("api/Teachers")]
    public class TeachersController : Controller
    {
        private LmsDbContext _db;
        private TeacherService _service;

        public TeachersController(LmsDbContext db, IGenericRepository<Teacher> repository)
        {
            _db = db;
            _service = new TeacherService(repository);
        }

        [HttpPost]
        [Route("Search")]

        public async Task<IActionResult> GetTeacher([FromBody] TeacherRequestModel request)
        {
            var teachers = await _service.SearchAsync(request);
            return Ok(teachers);
        }

        [HttpPost]
        [Route("Add")]

        public IActionResult AddTeacher([FromBody] Teacher teacher)
        {
            teacher.Id = Guid.NewGuid().ToString();

            teacher.Created = DateTime.Now;
            teacher.Modified = DateTime.Now;
            teacher.CreatedBy = "system";
            teacher.ModifiedBy = "system";
            teacher.IsActive = true;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool added = _service.Add(teacher);

            if (added)
            {
                return Ok(teacher.Id);
            }

            return BadRequest("Could't save this teacher.");
        }
    }
}