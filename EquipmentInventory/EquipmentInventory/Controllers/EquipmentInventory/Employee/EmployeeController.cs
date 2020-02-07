using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentInventory.Controllers.EquipmentInventory.Employee
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/EquipmentInventory/Employee/ManageEmployee/Index.cshtml");
        }
        public IActionResult Department()
        {
            return View("~/Views/EquipmentInventory/Employee/Department/DepartmentDashBoard.cshtml");
        }
        public IActionResult empAssignToDept()
        {
            return View("~/Views/EquipmentInventory/Employee/Department/empAssignToDepartment.cshtml");
        }
    }
}