using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentInventory.Controllers.EquipmentInventory.Settings
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/EquipmentInventory/Settings/department/Index.cshtml");
        }
        public IActionResult AdminSettings()
        {
            return View("~/Views/EquipmentInventory/Settings/AdminSettings/AdminSettingsDashboard.cshtml");
        }
    }
}