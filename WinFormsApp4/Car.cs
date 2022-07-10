using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Car
    {
     
        public string Model { get; set; }
        public string Vendor { get; set; }
        public string Year { get; set; }
        public string Engine { get; set; }
        public Car(string model, string vendor, string year, string engine)
        {
            Model = model;
            Vendor = vendor;
            Year = year;
            Engine = engine;
        }
    }
}
