using AutoMapper;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using WebApplication.ActionFilter;
using WebApplication.BusinessLogic;
using WebApplication.BusinessLogic.Interface;
using WebApplication.Domain.Entities.Services;
using WebApplication.Domain.Entities.Staff;
using WebApplication.Domain.Entities.User;
using WebApplication.Models;
using WebApplication.Models.uData;

namespace WebApplication.Controllers
{
    public class ServiceController : BaseController
    {
        private readonly ISession _session;
        private readonly IService _service;// GET: Service
        public ServiceController()
        {
            BussinesLogic bl = new BussinesLogic();
            _service = bl.GetServiceBL();
            _session = bl.GetSessionBL();
        }

        [UserMod]
        public ActionResult Index()
        { 
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }

            UserMinimal userMin = null;
            List<userWorkers> uStaff = new List<userWorkers>();
            userData u = new userData();
            
            HttpCookie CookieApi = System.Web.HttpContext.Current.Request.Cookies["X-KEY"];
            if (CookieApi != null)
            {
                userMin = _session.GetUserByCookie(CookieApi.Value);
            }
            if (userMin == null)
            {
                u.Username = "Username";
            }
            else
            {
                u.Username = userMin.Username;
            }
            List<Service> serviceData = _service.GetServices();
            List<Worker> staffData = _service.GetStaff();
            foreach(var s in staffData)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Worker, userWorkers>();
                });

                IMapper iMapper = config.CreateMapper();
                var localStaff = iMapper.Map<Worker, userWorkers>(s);
                uStaff.Add(localStaff);
            }

            u.staff = uStaff;
            
            u.services = serviceData;

            return View(u);
        }

        public ActionResult ServiceDetail(int id)
        {
            UserMinimal user = new UserMinimal();
            userData u = new userData();
            List<Worker> Workers = new List<Worker>();
            u.staff = new List<userWorkers>();

            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
           
            HttpCookie CookieApi = System.Web.HttpContext.Current.Request.Cookies["X-KEY"];
            if (CookieApi != null)
            {
                user = _session.GetUserByCookie(CookieApi.Value);
            }
            if (user == null)
            {
                u.Username = "utilizator neautentificat";
            }
            else
            {
                u.Username = user.Username;
            }

            u.lastServices = _service.GetServices();
            u.service = _service.GetSingleService(id);
            u.services = _service.GetServices();

            Workers = _service.GetStaff();

            u.lastServices = u.lastServices.GetRange(0, 2);

            foreach (var employee in Workers)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Worker, userWorkers>();
                });

                IMapper iMapper = config.CreateMapper();
                var localStaff = iMapper.Map<Worker, userWorkers>(employee);
                u.staff.Add(localStaff);
            }

            return View(u);
        }
    }
}