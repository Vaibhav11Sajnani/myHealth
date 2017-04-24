using myHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHealth
{
    class DataManager
    {
        public static Project project { get; set; }
        public static double pinValue { get; set; }

        public static async Task<Project> GetData()
        {
            project = await NetworkService.GetProject();
            if (project != null)
            {
                return project;
            }

            else
            {
                project.isActive = false;
                return project;
            }
        }

        public static async Task<double> GetPinValue(string pin)
        {
            var p = await NetworkService.GetPin(pin);
            pinValue = p[0];
            return pinValue;
        }
    }
}
