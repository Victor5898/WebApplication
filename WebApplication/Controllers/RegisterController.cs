using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.BusinessLogic.DbModel.Seed;
using WebApplication.Domain.Entities.User;
using WebApplication.Helper;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class RegisterController : BaseController
    {
        [HttpPost]
        public ActionResult Index(userRegister register)
        {
            URegisterResp reg = new URegisterResp();
            if (ModelState.IsValid)
            {
                register.Password = LoginHelper.HashGen(register.Password);
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<userRegister, UDbTable>();
                });

                IMapper iMapper = config.CreateMapper();
                var localProd = iMapper.Map<userRegister, UDbTable>(register);
                localProd.Level = 0;
                localProd.lastLogin = DateTime.Now;
                localProd.UserIp = Request.UserHostAddress;
                using (UserContext prod = new UserContext())
                {
                    prod.Users.Add(localProd);
                    prod.SaveChanges();
                }
            }
            else
            {
                ModelState.AddModelError("Parolele nu coincid!", reg.StatusMessage);
                return View();
            }
            return RedirectToAction("Index", "Login");
        }

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
    }
}