using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BookStore.Application.AppServices.Interfaces;
using BookStore.Domain.Account.Entities;
using BookStore.Web.ViewModel;

namespace BookStore.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserAppService _userAppService;

        public AccountController(IUserAppService userAppService)
        {
            this._userAppService = userAppService;
        }

        // GET: Account
        public ActionResult Index()
        {
            var userModelView = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userAppService.GetAll());
            _userAppService.Save();
            return View(userModelView);
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            var user = _userAppService.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);
            _userAppService.Save();
            return View(userViewModel);
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            _userAppService.Save();
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDomain = Mapper.Map<UserViewModel, User>(user);
                _userAppService.Add(userDomain);
                _userAppService.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _userAppService.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);
            _userAppService.Save();
            return View(userViewModel);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDomain = Mapper.Map<UserViewModel, User>(user);
                _userAppService.Edit(userDomain);
                _userAppService.Save();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var user = _userAppService.GetById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);
            _userAppService.Save();
            return View(userViewModel);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var user = _userAppService.GetById(id);
            _userAppService.Delete(user);
            _userAppService.Save();
            return RedirectToAction("Index");
        }
    }
}
