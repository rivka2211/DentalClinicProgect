using DentalClinic.Classes;
using DentalClinic.Controllers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicTesting
{
    public class AppointmentControllerTest
    {
        private readonly AppointmentController _appointmentController;
        public AppointmentControllerTest()
        {
            _appointmentController = new AppointmentController();
        }
        [Fact]
        public void GetAll_ReturnsOK()
        {
            var result = _appointmentController.Get();
            Assert.IsType<List<Appointment>>(result);
        }

        [Fact]
        public void GetByCode_ReturnsOK()
        {
            var result = _appointmentController.Get(0);
            Assert.IsType<Ok>(result);
        }
        [Fact]
        public void GetByCode_NoteFound()
        {
            var result = _appointmentController.Get(23);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
