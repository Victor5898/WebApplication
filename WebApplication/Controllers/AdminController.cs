using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ActionFilter;
using WebApplication.BusinessLogic;
using WebApplication.BusinessLogic.DbModel.Seed;
using WebApplication.BusinessLogic.Interface;
using WebApplication.Domain.Entities.Services;
using WebApplication.Domain.Entities.Staff;
using WebApplication.Domain.Entities.User;
using WebApplication.Domain.Enums;
using WebApplication.Models;
using WebApplication.Models.uData;

namespace WebApplication.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IAdmin _admin;
        private readonly ISession _session;
        private readonly IService _service;

        public AdminController()
        {
            BussinesLogic bl = new BussinesLogic();
            _admin = bl.GetAdminBL();
            _session = bl.GetSessionBL();
            _service = bl.GetServiceBL();
        }

        // GET: Admin
        [AdminMod]
        public ActionResult Index()
        {
            UserMinimal singleUser = new UserMinimal();
            userData users = new userData();
            users.staff = new List<userWorkers>();

            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }

            HttpCookie CookieApi = System.Web.HttpContext.Current.Request.Cookies["X-KEY"];
            if (CookieApi != null)
            {
                singleUser = _session.GetUserByCookie(CookieApi.Value);
            }
            if (singleUser == null)
            {
                users.Username = "Username";
            }
            else
            {
                users.Username = singleUser.Username;
            }

            List<Worker> worker = _service.GetStaff();

            foreach (var singleWorker in worker)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Worker, userWorkers>();
                });

                IMapper iMapper = config.CreateMapper();
                var localWorker = iMapper.Map<Worker, userWorkers>(singleWorker);
                users.staff.Add(localWorker);
            }
                
            users.users = _admin.GetUsers();
            users.services = _service.GetServices();

            return View(users);
        }

        public ActionResult Add()
        {
            return View();
        }

        [AdminMod]
        [HttpPost]
        public ActionResult AddService(adminData service)
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }

            if (ModelState.IsValid)
            {
                service.Image = "/Content/images/it-service/" + service.Image;
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<adminData, SDbTable>();
                });

                IMapper iMapper = config.CreateMapper();

                var localService = iMapper.Map<adminData, SDbTable>(service);
                using (ServiceContext services = new ServiceContext())
                {
                    services.Services.Add(localService);
                    services.SaveChanges();

                }
            }

            return RedirectToAction("Index", "Admin");
        }


        [AdminMod]
        [HttpPost]
        public ActionResult AddAdministrator(adminData admin)
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
            if (ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<adminData, UDbTable>();
                });

                IMapper iMapper = config.CreateMapper();

                var localUser = iMapper.Map<adminData, UDbTable>(admin);
                localUser.Level = (URole)1;
                localUser.lastLogin = DateTime.Now;
                localUser.UserIp = Request.UserHostAddress;
                using (UserContext lessons = new UserContext())
                {
                    lessons.Users.Add(localUser);
                    lessons.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult AddWorker(adminData employee)
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
            if (ModelState.IsValid)
            {
                employee.Image = "/Content/images/it-service/" + employee.Image;
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<adminData, WDbTable>();
                });

                IMapper iMapper = config.CreateMapper();

                var localWorker = iMapper.Map<adminData, WDbTable>(employee);
                using (WorkerContext worker = new WorkerContext())
                {
                    worker.Workers.Add(localWorker);
                    worker.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}