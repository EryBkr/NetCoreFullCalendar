using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Bussiness.Abstract;
using ToDoList.DataAccess.Abstract;

namespace ToDoList.Bussiness.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserDal appUserDal;

        public AppUserService(IAppUserDal appUserDal)
        {
            this.appUserDal = appUserDal;
        }
    }
}
