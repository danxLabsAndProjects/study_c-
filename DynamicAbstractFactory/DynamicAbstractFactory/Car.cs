using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    enum Parts {Wheel,
        Body,Motor};
    enum Factories {NissanFactory,MercedesFactory};

    class Car
    {

        private dynamic factory;
        private dynamic wheel;
        private dynamic motor;
        private dynamic body;

        public Car(Factories factory)
        {
            string name = GetType().Namespace + "." + factory;
            this.factory = Activator.CreateInstance(Type.GetType(name));
            this.wheel = this.factory.Make(Parts.Wheel);
            this.motor = this.factory.Make(Parts.Motor);
            this.body = this.factory.Make(Parts.Body);

        }

        public void WhatCarIsIt()
        {
            Console.WriteLine($"Motor power : {this.motor.Power}");
            Console.WriteLine($"Body level : {this.body.Level}");
            Console.WriteLine($"Wheel diametr {this.wheel.Diametr}");
        }

    }
}
