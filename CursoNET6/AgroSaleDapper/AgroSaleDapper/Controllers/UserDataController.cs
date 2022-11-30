using AgroSaleDapper.Models;
using AgroSaleDapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace AgroSaleDapper.Controllers
{
    public class UserDataController : Controller
    {
        private readonly IRepositoryUserData repositoryUserData;
        private readonly IServiceUser serviceUser;
        public UserDataController(IRepositoryUserData repositoryUserData,
                                  IServiceUser serviceUser)
        {
            this.repositoryUserData = repositoryUserData;
            this.serviceUser = serviceUser;
        }

        //LIST
        public async Task<IActionResult> Index()
        {
            var userId = serviceUser.GetUserId();
            var userData = await repositoryUserData.GetUserData(userId);
            return View(userData);
        }

        public IActionResult Crear()
        {

            return View();
        }

        //Se debe validar si el modelo es valido para que funcionen todas las validaciones 
        //Create
        [HttpPost]
        public async Task<IActionResult> Crear(UserData userData)
        {
            if (!ModelState.IsValid)
            {
                return View(userData);
            }

            userData.UserId = serviceUser.GetUserId();

            await repositoryUserData.Create(userData);
            return RedirectToAction("Index");


        }
        //Update
        [HttpGet]
        public async Task<ActionResult> Update(int id)
        {
            var userId = serviceUser.GetUserId();
            var userData = await repositoryUserData.GetForId(id, userId);
            if (userData is null)
            {
                return RedirectToAction("NoFound", "Home");
            }
            return View(userData);
        }
        //Update
        [HttpPost]
        public async Task<ActionResult> Update(UserData userData)
        {
            var userId = serviceUser.GetUserId();
            var ExistUser = await repositoryUserData.GetForId(userData.Id, userId);
            if(ExistUser is null)
            {
                return RedirectToAction("NoFound","Home");
            }

            await repositoryUserData.Update(userData);
            return RedirectToAction("Index");
        }

        //Obtener id para saber cual boorrar
        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            var UserId= serviceUser.GetUserId();
            var UserData = await repositoryUserData.GetForId(Id,UserId);

            if(UserData is null)
            {
               return RedirectToAction("NoFound","Home");
            }
            return View(UserData);
        }
        //Realizar Borrado
        [HttpPost]
        public async Task<IActionResult> DeleteUserData(int Id)
        {
            var UserId = serviceUser.GetUserId();
            var UserData = await repositoryUserData.GetForId(Id, UserId);

            if (UserData is null)
            {
                return RedirectToAction("NoFound", "Home");
            }
            await repositoryUserData.Delete(Id);
            return RedirectToAction("Index");
        }

        
    }
}
