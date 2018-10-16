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
            TimeConsumingModel service = new TimeConsumingModel();
            var content = service.HeavyContent1();
            var count = service.HeavyContent2();
            var name = service.HeavyContent3();

            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> IndexAsync()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            TimeConsumingModel service = new TimeConsumingModel();
            var contentTask = service.HeavyContent1Async();
            var countTask = service.HeavyContent2Async();
            var nameTask = service.HeavyContent3Async();

            var content = await contentTask;
            var count = await countTask;
            var name = await nameTask;
            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
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
