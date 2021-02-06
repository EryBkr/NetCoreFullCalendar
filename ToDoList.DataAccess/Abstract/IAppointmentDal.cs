using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.DataAccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Abstract
{
    public interface IAppointmentDal:IEntityRepository<Appointment>
    {
        List<Appointment> GetListIncludeUser(int userId);
    }
}
