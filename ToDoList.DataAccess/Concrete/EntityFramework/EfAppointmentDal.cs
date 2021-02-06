using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Core.DataAccess.Concrete.EntityFramework;
using ToDoList.DataAccess.Abstract;
using ToDoList.DataAccess.Concrete.EntityFramework.Context;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Concrete.EntityFramework
{
    public class EfAppointmentDal : EfEntityRepositoryBase<MyDataContext, Appointment>, IAppointmentDal
    {
        public List<Appointment> GetListIncludeUser(int userId)
        {
            using(MyDataContext myDataContext=new MyDataContext())
            {
                var model = new List<Appointment>();
                if (userId>0)
                {
                    model = myDataContext.Appointments.Include(i => i.AppUser).Where(i=>i.AppUserId==userId).ToList();
                }
                else
                {
                    model = myDataContext.Appointments.Include(i => i.AppUser).ToList();
                }
                
                return model;
            }
        }
    }
}
