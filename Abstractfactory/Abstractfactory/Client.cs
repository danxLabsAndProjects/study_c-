using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class Client
    {
        Body body;
        Motor motor;
        Wheel wheel;

        public Client(Factory factory)
        {
            body = factory.CreateBody();
            motor = factory.CreateMotor();
            wheel = factory.CreateWheel();
        }

        public void WhatCarIsIt()
        {
            Console.WriteLine("This car has");
            Console.WriteLine($"Body : {body.Level}");
            Console.WriteLine($"Motor : {motor.Power}");
            Console.WriteLine($"Wheel : {wheel.Diameter}");
        }

    }
}
