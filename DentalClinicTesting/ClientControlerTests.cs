﻿using DentalClinic.Classes;
using DentalClinic.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicTesting
{
    public class ClientControlerTests
    {
        private readonly ClientController _clientContorller;

        public ClientControlerTests()
        {
            _clientContorller = new ClientController();
        }


        [Fact]
        public void GetAll_ReturnsOK()
        {
            var controller = new ClientController();
            var result = controller.Get();

            Assert.IsType<List<Client>>(result);
        }
    }
}
