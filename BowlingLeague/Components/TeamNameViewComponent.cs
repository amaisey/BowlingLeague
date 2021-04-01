using System;
using System.Linq;
using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;

namespace BowlingLeague.Components
{
    public class TeamNameViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamNameViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamname"];

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
