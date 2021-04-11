using Hotel_reservations_manager.Helpers;
using Hotel_reservations_manager.Models;
using Hotel_reservations_manager.Models.Rooms;
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
    public class RoomsController : Controller
    {
        private const int PageSize = 10;
        private readonly HotelContext _context;

        public RoomsController()
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

        // GET: Rooms
        public async Task<IActionResult> List(RoomsViewModel model)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            bool isAdmin = IsAdminAndActive();
            List<Room> items;

            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            if (isAdmin)
            {
                items = _context.Rooms.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new Room()
                {
                    Id = c.Id,
                    Number = c.Number,
                    Capacity = c.Capacity,
                    Price = c.Price,
                    Description = c.Description,
                    Type = c.Type,
                    IsFree = c.IsFree
                }).ToList();
            }
            else
            {
                items = _context.Rooms.Where(c => c.IsFree).Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new Room()
                {
                    Id = c.Id,
                    Number = c.Number,
                    Capacity = c.Capacity,
                    Price = c.Price,
                    Description = c.Description,
                    Type = c.Type,
                    IsFree = c.IsFree
                }).ToList();
            }

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Rooms.CountAsync() / (double)PageSize);
            model.IsAdmin = isAdmin;

            return View(model);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if(!IsAdminAndActive())
                return Redirect("/Rooms/List");

            RoomsCreateModel model = new RoomsCreateModel();

            return View(model);
        }

        // POST: Rooms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomsCreateModel model)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/Rooms/List");

            if (ModelState.IsValid)
            {
                Room room = new Room
                {
                    Number = model.Number,
                    Capacity = model.Capacity,
                    Price = model.Price,
                    Description = model.Description,
                    Type = model.Type,
                    IsFree = model.IsFree
                };

                _context.Add(room);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(List));
            }

            return View(model);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/Rooms/List");

            if (id == null)
            {
                return NotFound();
            }

            Room room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            RoomsEditModel model = new RoomsEditModel
            {
                Id = room.Id,
                Number = room.Number,
                Capacity = room.Capacity,
                Price = room.Price,
                Description = room.Description,
                Type = room.Type,
                IsFree = room.IsFree
            };

            return View(model);
        }

        // POST: Rooms/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RoomsEditModel model)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/Rooms/List");

            if (ModelState.IsValid)
            {
                Room room = new Room
                {   
                    Id = model.Id,
                    Number = model.Number,
                    Capacity = model.Capacity,
                    Price = model.Price,
                    Description = model.Description,
                    Type = model.Type,
                    IsFree = model.IsFree
                };

                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return Redirect("/Rooms/List");
            }
            return View(model);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (!IsUserAuthenticated())
                return Redirect("/Users/Login");

            if (!IsAdminAndActive())
                return Redirect("/Rooms/List");

            Room room = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return Redirect("/Rooms/List");
        }

        private bool RoomExists(int id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }
    }
}
