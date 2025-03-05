using LavenderMaster.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LavenderMaster.Controllers
{
    /*public class HomeController : Controller
    {
        public readonly PostgresContext _context;
        public HomeController(PostgresContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var c = _context.Stations.FirstOrDefault();
            return View();
        }

        public IActionResult Privacy()
        {
            var c = _context.Stations.SingleOrDefault(s => s.Id == 1);
            c.Content = "asdasdsad";
            _context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }*/



    public class HomeController : Controller
    {
        public string Password_LAVENDERDB = "8545";
        public string Username_LAVENDERDB = "postgres";
        public List<Stations> stations;


        public readonly PostgresContext _context;
        public HomeController(PostgresContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["stations"] = GetAllStation();
            ViewData["stations_all"] = GetAllStation_Count();
            ViewData["stations_good"] = GetGoodStation_Count();
            ViewData["stations_bad"] = GetBadStation_Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public List<Stations> GetAllStation()
        {
            stations = _context.Stations.OrderBy(s => s.Id).ToList();
            return stations;
        }

        public int GetAllStation_Count()
        {
            int stations_all = _context.Stations.Count();
            return stations_all;
        }

        public int GetGoodStation_Count()
        {
            int stations_good = _context.Stations.Where(g => g.Content != null).Count();
            return stations_good;
        }

        public int GetBadStation_Count()
        {
            int stations_bad = _context.Stations.Where(g => g.Content == null).Count();
            return stations_bad;
        }

        public void download(int station_id)
        {
            var s = _context.Stations.SingleOrDefault(s => s.Id == station_id);
            s.Content = "11111";
            _context.SaveChanges();
        }
    }
}
