using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApplication.BusinessLogic.DbModel.Seed;
using WebApplication.Domain.Entities.Services;
using WebApplication.Domain.Entities.Session;
using WebApplication.Domain.Entities.Staff;
using WebApplication.Domain.Entities.User;
using WebApplication.Helper;

namespace WebApplication.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {

            UDbTable user;
            var validateEmail = new EmailAddressAttribute();
            var password = LoginHelper.HashGen(data.Password);
            if (validateEmail.IsValid(data.Credential))
            {
                using (var db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == password);
                }

                if (user == null)
                {
                    return new ULoginResp { Status = false, StatusMessage = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    user.UserIp = data.LoginIp;
                    user.lastLogin = data.LoginDataTime;
                    todo.Entry(user).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
            else
            {
                using (var db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == password);
                }

                if (user == null)
                {
                    return new ULoginResp { Status = false, StatusMessage = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    user.UserIp = data.LoginIp;
                    user.lastLogin = data.LoginDataTime;
                    todo.Entry(user).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
        }

        internal HttpCookie GenerateCookie(string Credential)
        {
            var apiCookie = new HttpCookie("X-KEY")
            {
                Value = CookieGenerator.Create(Credential)
            };
            using (var db = new SessionContext())
            {
                SessionDbTable currentCookie;
                var validate = new EmailAddressAttribute();
                if (validate.IsValid(Credential))
                {
                    currentCookie = (from e in db.Sessions where e.Username == Credential select e).FirstOrDefault();
                }
                else
                {
                    currentCookie = (from e in db.Sessions where e.Username == Credential select e).FirstOrDefault();
                }

                if (currentCookie == null)
                {
                    db.Sessions.Add(new SessionDbTable { Username = Credential, CookieString = apiCookie.Value, ExpireTime = DateTime.Now.AddMinutes(60) });
                    db.SaveChanges();
                }
                else
                {
                    currentCookie.CookieString = apiCookie.Value;
                    currentCookie.ExpireTime = DateTime.Now.AddMinutes(60);
                    using (var todo = new SessionContext())
                    {
                        todo.Entry(currentCookie).State = EntityState.Modified;
                        todo.SaveChanges();
                    }
                }
            }
            return apiCookie;
        }

        internal UserMinimal UserCookie(string CookieApi)
        {
            SessionDbTable session;
            UDbTable curentUser;

            using (var db = new SessionContext())
            {
                session = db.Sessions.FirstOrDefault(s => s.CookieString == CookieApi && s.ExpireTime > DateTime.Now);
            }

            if (session == null)
            {
                return null;
            }
            using (var db = new UserContext())
            {
                var validate = new EmailAddressAttribute();
                if (validate.IsValid(session.Username))
                {
                    curentUser = db.Users.FirstOrDefault(u => u.Email == session.Username);
                }
                else
                {
                    curentUser = db.Users.FirstOrDefault(u => u.Username == session.Username);
                }
            }
            if (curentUser == null)
            {
                return null;
            }
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UDbTable, UserMinimal>();
            });
            IMapper iMapper = config.CreateMapper();
            var userminimal = iMapper.Map<UserMinimal>(curentUser);

            return userminimal;
        }

        internal List<Worker> GetStaffAction()
        {
            List<WDbTable> worker;

            List<Worker> staffData = new List<Worker>();
            Database.SetInitializer<WorkerContext>(null);
            using (var db = new WorkerContext())
            {
                worker = db.Workers.ToList();
            }

            foreach (var singlePerson in worker)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap <WDbTable, Worker>();
                });

                IMapper iMapper = config.CreateMapper();
                var localProd = iMapper.Map<WDbTable, Worker>(singlePerson);

                staffData.Add(localProd);
            }

            return staffData;
        }

        internal List<UserMinimal> GetUsersAdmin()
        {
            List<UDbTable> users;

            List<UserMinimal> uData = new List<UserMinimal>();
            Database.SetInitializer<UserContext>(null);
            using (var db = new UserContext())
            {
                users = db.Users.ToList();
            }

            foreach (var u in users)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<UDbTable, UserMinimal>();
                });

                IMapper iMapper = config.CreateMapper();
                var localUsers = iMapper.Map<UDbTable, UserMinimal>(u);

                uData.Add(localUsers);
            }

            return uData;
        }

        internal List<Service> GetServicesAction()
        {
            List<SDbTable> services;

            List<Service> sData = new List<Service>();
            Database.SetInitializer<UserContext>(null);
            using (var db = new ServiceContext())
            {
                services = db.Services.ToList();
            }

            foreach (var s in services)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<SDbTable, Service>();
                });

                IMapper iMapper = config.CreateMapper();
                var localServices = iMapper.Map<SDbTable, Service>(s);

                sData.Add(localServices);
            }

            return sData;
        }

        public Service GetSingleServiceAction(int id)
        {
            SDbTable singleService;
            using (var db = new ServiceContext())
            {
                singleService = db.Services.FirstOrDefault(u => u.Id == id);
            }
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SDbTable, Service>();
            });

            IMapper iMapper = config.CreateMapper();
            var localProduct = iMapper.Map<SDbTable, Service>(singleService);

            return localProduct;
        }

    }    
}
