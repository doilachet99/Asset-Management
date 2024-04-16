using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace WebApplication1.Models
{
    public class Devices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public List<Devices> GetDevices()
        {
            List<Devices> devicesList = new List<Devices>();

            devicesList.Add(new Devices()
            {
                Id = 1,
                Name = "Test",
                Description = "Test-1"
            });

            devicesList.Add(new Devices()
            {
                Id = 2,
                Name = "Test2",
                Description = "Test-2"
            });
            devicesList.Add(new Devices()
            {
                Id = 3,
                Name = "Test3",
                Description = "Test-3"
            });
            devicesList.Add(new Devices()
            {
                Id = 4,
                Name = "Test4",
                Description = "Test-4"
            });
            return devicesList;
        }
    }
}