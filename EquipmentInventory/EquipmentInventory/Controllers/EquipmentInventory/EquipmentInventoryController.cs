﻿
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace EquipmentInventory.Controllers
{
    public class EquipmentInventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}