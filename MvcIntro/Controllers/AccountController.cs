using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcIntro.Models;

namespace MvcIntro.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            var viewModel = new AccountRegisterViewModel();

            viewModel.Cities.Add(new SelectListItem() { Text = "Kyiv", Value = "1" });
            viewModel.Cities.Add(new SelectListItem() { Text = "Zaporizhzhia", Value = "2" });
            viewModel.Cities.Add(new SelectListItem() { Text = "Dnipro", Value = "3" });
            viewModel.Cities.Add(new SelectListItem() { Text = "Kharkiv", Value = "4" });

            return View(viewModel);
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AccountRegisterViewModel accountRegisterModel)
        {
            if (ModelState.IsValid)
            {
                //TODO: Add model to storage
                //TODO: Show page with details
                return RedirectToAction("Details", new { id = accountRegisterModel.Id });
            }
            else
            {
                accountRegisterModel.Cities.Add(new SelectListItem() { Text = "Kyiv", Value = "1" });
                accountRegisterModel.Cities.Add(new SelectListItem() { Text = "Zaporizhzhia", Value = "2" });
                accountRegisterModel.Cities.Add(new SelectListItem() { Text = "Dnipro", Value = "3" });
                accountRegisterModel.Cities.Add(new SelectListItem() { Text = "Kharkiv", Value = "4" });

                return View(accountRegisterModel);
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
