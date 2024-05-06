﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }
        
        public Manager(string name) : base(name, managerHourlyRate)
        {
            role = "Manager";
        }
        public override void Calculate()
        {
            base .Calculate();
            Allowance = 1000;
            if (HoursWorked > 160 )
            {
                TotalPay += Allowance;
            }
        }
    }
}
