using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class Car
    {
        private DateTime _manufactorDate;
        private string? _serialNumber;
        private string? _brand;
        private string? _model;
        private string? _color;
        private int _doorCount;

        public Car(string? serialNumber, string? brand, string? model, string? color, int doorCount)
        {
            ManufactorDate = DateTime.Now;
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount;
        }

        public DateTime ManufactorDate { get => _manufactorDate; set => _manufactorDate = value; }
        public string? SerialNumber { get => _serialNumber; set => _serialNumber = value; }
        public string? Brand { get => _brand; set => _brand = value; }
        public string? Model { get => _model; set => _model = value; }
        public string? Color { get => _color; set => _color = value; }
        public int DoorCount { get => _doorCount; set => _doorCount = value; }
    }
}
