using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ToDoList.Bussiness.Abstract;
using ToDoList.Entities.Concrete;
using ToDoList.WEB.Models;

namespace ToDoList.WEB.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly IAppointmentService appointmentsService;

        public AppointmentsController(IAppointmentService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        public JsonResult GetAppointments(int userId)
        {
            var appointments = appointmentsService.GetListIncludeUser(userId);

            var models = new List<AppointmentsViewModel>();
            foreach (var item in appointments)
            {
                models.Add(new AppointmentsViewModel 
                {
                    AppUserId=item.AppUserId,
                    Title=item.AppUser.Name+" randevunuz var",
                    Color=item.AppUser.Color,
                    Description=item.Description,
                    EndDate=item.EndDate,
                    Id=item.Id,
                    PatientName=item.PatientName,
                    PatientSurname=item.PatientSurname,
                    StartDate=item.StartDate
                });
            }
            return Json(models);
        }

        [HttpPost]
        public JsonResult AddOrUpdateAppointment(Appointment model)
        {
            if (model.Id==0)
            {
                model.CreatedName = DateTime.Now;
                appointmentsService.Add(model);
            }
            else
            {
                model.UpdatedDate = DateTime.Now;
                appointmentsService.Update(model);
            }
            return Json("200");
        }

        public JsonResult Delete(int id)
        {
            var appointment = appointmentsService.Get(i => i.Id == id);
            appointmentsService.Delete(appointment);
            return Json("200");
        }
    }
}
