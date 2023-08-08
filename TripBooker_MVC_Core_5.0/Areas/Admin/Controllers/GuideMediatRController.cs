using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripBooker_MVC_Core_5._0.CQRS.Commands.GuideCommands;
using TripBooker_MVC_Core_5._0.CQRS.Queries.GuideQueries;

namespace TripBooker_MVC_Core_5._0.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;
        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var values = await _mediator.Send(new GetGuideByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}