using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentInventory.Controllers.EquipmentInventory.Item
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/EquipmentInventory/Item/Index.cshtml");
        }
    }
}