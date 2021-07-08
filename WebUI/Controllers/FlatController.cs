using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class FlatController : Controller
    {
        private readonly IMapper _mapper = null;
        private readonly IFlatService _flatService = null;

        public FlatController(IMapper mapper, IFlatService flatService)
        {
            _mapper = mapper;
            _flatService = flatService;
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Add(FlatViewModel flat)
        {
            var result = await _flatService.Add(flat);

            if (result==true)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }
    }
}
