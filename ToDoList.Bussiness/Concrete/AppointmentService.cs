using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ToDoList.Bussiness.Abstract;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.Bussiness.Concrete
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentDal appointmentDal;

        public AppointmentService(IAppointmentDal appointmentDal)
        {
            this.appointmentDal = appointmentDal;

        }
        public void Add(Appointment entity)
        {
            appointmentDal.Add(entity);
        }

        public void Delete(Appointment entity)
        {
            appointmentDal.Delete(entity);
        }

        public Appointment Get(Expression<Func<Appointment, bool>> filter = null)
        {
            var appointment = appointmentDal.Get(filter);
            return appointment;
        }

        public List<Appointment> GetList(Expression<Func<Appointment, bool>> filter = null)
        {
            var appointments = appointmentDal.GetList(filter);
            return appointments;
        }

        public List<Appointment> GetListIncludeUser(int userId)
        {
            return appointmentDal.GetListIncludeUser(userId);
        }

        public void Update(Appointment entity)
        {
            appointmentDal.Update(entity);
        }
    }
}
