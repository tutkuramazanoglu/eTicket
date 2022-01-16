using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Data;
using eTicket.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _services;

        public ActorsController(IActorsService services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var allActors =await _services.GetAll();
            return View(allActors);
        }
    }
}
