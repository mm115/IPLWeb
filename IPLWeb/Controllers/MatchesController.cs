using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IPLWeb.Data;
using IPLWeb.Models;
using Microsoft.AspNetCore.Authorization;

namespace IPLWeb.Controllers
{
    [Authorize(Roles = "admin")]
    public class MatchesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatchesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Matches
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Matches.Include(m => m.Season).Include(m => m.Team1).Include(m => m.Team2);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Matches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Matches
                .Include(m => m.Season)
                .Include(m => m.Team1)
                .Include(m => m.Team2)
                .FirstOrDefaultAsync(m => m.TeamID == id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        // GET: Matches/Create
        public IActionResult Create()
        {
            ViewData["SeasonID"] = new SelectList(_context.Seasons, "SeasonID", "SeasonYear");
            ViewData["TeamID1"] = new SelectList(_context.Teams, "TeamID", "TeamName");
            ViewData["TeamID2"] = new SelectList(_context.Teams, "TeamID", "TeamName");
            return View();
        }

        // POST: Matches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeamID,VenueName,MatchDate,MatchTime,SeasonID,TeamID1,TeamID2")] Match match)
        {
            if (ModelState.IsValid)
            {
                if (match.TeamID1 == match.TeamID2)
                {
                    ModelState.AddModelError("TeamID2", "Both Team are Same. Choose Different Teams");
                }
                else
                {
                    _context.Add(match);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["SeasonID"] = new SelectList(_context.Seasons, "SeasonID", "SeasonYear", match.SeasonID);
            ViewData["TeamID1"] = new SelectList(_context.Teams, "TeamID", "TeamName", match.TeamID1);
            ViewData["TeamID2"] = new SelectList(_context.Teams, "TeamID", "TeamName", match.TeamID2);
            return View(match);
        }

        // GET: Matches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Matches.FindAsync(id);
            if (match == null)
            {
                return NotFound();
            }
            ViewData["SeasonID"] = new SelectList(_context.Seasons, "SeasonID", "SeasonYear", match.SeasonID);
            ViewData["TeamID1"] = new SelectList(_context.Teams, "TeamID", "TeamName", match.TeamID1);
            ViewData["TeamID2"] = new SelectList(_context.Teams, "TeamID", "TeamName", match.TeamID2);
            return View(match);
        }

        // POST: Matches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeamID,VenueName,MatchDate,MatchTime,SeasonID,TeamID1,TeamID2")] Match match)
        {
            if (id != match.TeamID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if(match.TeamID1 == match.TeamID2)
                {
                    ModelState.AddModelError("TeamID2", "Both Team are Same. Choose Different Teams");
                }
                else
                {
                    try
                    {
                        _context.Update(match);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MatchExists(match.TeamID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }                
            }
            ViewData["SeasonID"] = new SelectList(_context.Seasons, "SeasonID", "SeasonYear", match.SeasonID);
            ViewData["TeamID1"] = new SelectList(_context.Teams, "TeamID", "TeamName", match.TeamID1);
            ViewData["TeamID2"] = new SelectList(_context.Teams, "TeamID", "TeamName", match.TeamID2);
            return View(match);
        }

        // GET: Matches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Matches
                .Include(m => m.Season)
                .Include(m => m.Team1)
                .Include(m => m.Team2)
                .FirstOrDefaultAsync(m => m.TeamID == id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        // POST: Matches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var match = await _context.Matches.FindAsync(id);
            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchExists(int id)
        {
            return _context.Matches.Any(e => e.TeamID == id);
        }
    }
}
