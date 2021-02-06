using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Business.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.Bussiness.Abstract
{
    public interface IAppointmentService:IGenericService<Appointment>
    {
        List<Appointment> GetListIncludeUser(int userId);
    }
}
