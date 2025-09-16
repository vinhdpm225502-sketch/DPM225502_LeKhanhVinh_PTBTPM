﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM225502_LeKhanhVinh_Pattern01_AbstractFactory.Factories;

namespace DPM225502_LeKhanhVinh_Pattern01_AbstractFactory
{
    internal class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;
        // Constructor
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }
        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }

    }
}
