using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsynchronousProg.Models;

namespace AsynchronousProg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            TimeConsumingModel model = new TimeConsumingModel();
            var content = model.HeavyContent1();
            var count = model.HeavyContent2();
            var name = model.HeavyContent3();

            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            ViewBag.Content = content.ToString() + " - " + count+ " - " + name;
            return View();
        }

    //[HttpGet]
        public async Task<ActionResult> IndexAsync()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            TimeConsumingModel model = new TimeConsumingModel();

            //Lanzo las 3 tareas
            var contentTask = model.HeavyContent1Async();
            var countTask = model.HeavyContent2Async();
            var nameTask = model.HeavyContent3Async();

            //Espero que terminen las tres
            var content = await contentTask;
            var count =  await countTask;
            var name =  await nameTask;
            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            ViewBag.Content = content.ToString() + " - "+ count +" - "+ name;
            return View("Index");
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
}
