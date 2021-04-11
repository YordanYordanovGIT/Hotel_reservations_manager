using Hotel_reservations_manager.Helpers;
using Hotel_reservations_manager.Models;
using Hotel_reservations_manager.Models.Admins;
using Hotel_reservations_manager.Models.Shared;
using Hotel_reservations_manager.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Controllers
{
    public class AdminsController : Controller
    {
        private const int PageSize = 10;
        private readonly HotelContext _context;

        public AdminsController()
        {
            _context = new HotelContext();
        }

        private bool IsUserAuthenticated()
        {
            IAuthenticationHelper authHelper = new SessionAuthenticationHelper(HttpContext.Session);
            return authHelper.IsUserAuthenticated();
        }

        private bool IsAdminAndActive()
        {
            IAuthenticationHelper authHelper = new SessionAuthenticationHelper(HttpContext.Session);
            return authHelper.IsAdminAndActive();
        }

        // GET: List
        public async Task<IActionResult> List(AdminsViewModel model)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/");

            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<User> items = _context.Users.Where(e => e.Role == Role.Admin).Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new User()
            {
                Id = c.Id,
                Username = c.Username,
                Password = c.Password,
                FirstName = c.FirstName,
                MiddleName = c.MiddleName,
                LastName = c.LastName,
                PersonalID = c.PersonalID,
                PhoneNumber = c.PhoneNumber,
                Email = c.Email,
                Active = c.Active,
                Role = c.Role
            }).ToList();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Rooms.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/");

            if (id == null)
            {
                return NotFound();
            }

            User admin = await _context.Users.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            AdminsEditModel model = new AdminsEditModel
            {
                Id = admin.Id,
                Role = admin.Role,
                Username = admin.Username,
                Password = admin.Password,
                FirstName = admin.FirstName,
                MiddleName = admin.MiddleName,
                LastName = admin.LastName,
                PersonalID = admin.PersonalID,
                PhoneNumber = admin.PhoneNumber,
                Email = admin.Email,
                Active = admin.Active
            };

            return View(model);
        }

        // POST: Admins/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AdminsEditModel model)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/");

            if (ModelState.IsValid)
            {
                User admin = new User
                {
                    Id = model.Id,
                    Username = model.Username,
                    Password = model.Password,
                    FirstName = model.FirstName,
                    MiddleName = model.MiddleName,
                    LastName = model.LastName,
                    PersonalID = model.PersonalID,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Active = model.Active,
                    Role = model.Role
                };

                try
                {
                    _context.Update(admin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return Redirect("/Admins/List");
            }
                
            return View(model);
        }

        // GET: Admins/Activate/5
        public async Task<IActionResult> Activate(int id)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/");

            User admin = await _context.Users.FindAsync(id);
            if(admin != null)
                admin.Active = true;
            _context.Users.Update(admin);
            await _context.SaveChangesAsync();

            return Redirect("/Admins/List");
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/");

            User admin = await _context.Users.FindAsync(id);
            _context.Users.Remove(admin);
            await _context.SaveChangesAsync();

            return Redirect("/Admins/List");
        }

        private bool AdminExists(int id)
        {
            return _context.Users.Where(e => e.Role == Role.Admin).Any(e => e.Id == id);
        }
    }
}
