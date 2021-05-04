using IPLWeb.Data;
using IPLWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IPLWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Teams.ToListAsync());
        }

        public async Task<IActionResult> ViewMatches(int? id)
        {
            var team = await _context.Teams.FindAsync(id);
            ViewData["TeamName"] = "None";
            if (team != null)
            {
                ViewData["TeamName"] = team.TeamName;
            }
            var applicationDbContext = _context.Matches
                .Include(m => m.Season)
                .Include(m => m.Team1)
                .Include(m => m.Team2)
                .Where(m => m.TeamID1 == id || m.TeamID2 == id );
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> AllMatches(int? id)
        {
            var seasons = _context.Seasons.Select(s => new
            {
                s.SeasonID,
                SeasonName = s.SeasonYear + " Season"
            }).ToList();



            ViewData["Seasons"] = new SelectList(seasons, "SeasonID", "SeasonName", id.GetValueOrDefault(0));

            
            if (id.GetValueOrDefault(0) != 0)
            {
               var  applicationDbContext = _context.Matches
                .Include(m => m.Season)
                .Include(m => m.Team1)
                .Include(m => m.Team2)
                .Where(m => m.SeasonID == id);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                var applicationDbContext = _context.Matches
                .Include(m => m.Season)
                .Include(m => m.Team1)
                .Include(m => m.Team2);
                return View(await applicationDbContext.ToListAsync());
            }

            
        }

        public async Task<IActionResult> MatchCentre(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Matches
                .Include(m => m.Season)
                .Include(m => m.Team1)
                .Include(m => m.Team2)
                .Include(m => m.Comments)
                .FirstOrDefaultAsync(m => m.TeamID == id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        [Authorize]
        public IActionResult AddComment(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var match = _context.Matches
                .Include(m => m.Season)
                .Include(m => m.Team1)
                .Include(m => m.Team2)
                .FirstOrDefault(m => m.TeamID == id);
            if (match == null)
            {
                return NotFound();
            }

            ViewData["MatchID"] = match.TeamID;
            ViewData["VenueName"] = match.VenueName;
            ViewData["Team1"] = match.Team1.TeamName;
            ViewData["Team2"] = match.Team2.TeamName;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("CommentID,CommentText,MatchID")] Comment comment)
        {
            ModelState.Remove("CommentDate");
            ModelState.Remove("UserID");
            if (ModelState.IsValid)
            {
                comment.UserID = _userManager.GetUserName(this.User);
                comment.CommentDate = DateTime.Now;
                _context.Add(comment);
                await _context.SaveChangesAsync();            
            }
            return RedirectToAction(nameof(MyComments));
        }

        [Authorize]
        public async Task<IActionResult> MyComments()
        {
            string userid = _userManager.GetUserName(this.User);
            var comments = _context.Comments
                .Include(m => m.Match)
                .Include(m => m.Match.Team1)
                .Include(m => m.Match.Team2)
                .Where(m => m.UserID == userid);
            return View(await comments.OrderByDescending(m => m.CommentID).ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
