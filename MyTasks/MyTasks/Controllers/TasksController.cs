using MyTasks.Models;
using MyTasks.Repositories;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace MyTasks.Controllers
{
    public class TasksController : Controller
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyTasksConnection"].ConnectionString;
        private readonly TasksRepository _tasksRepository;

        public TasksController()
        {
            _tasksRepository = new TasksRepository(_connectionString);
        }

        // GET: Tasks
        public ActionResult Index()
        {
            List<Task> tasks = _tasksRepository.Tasks();
            return View(tasks);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                _tasksRepository.CreateTask(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }
    }
}