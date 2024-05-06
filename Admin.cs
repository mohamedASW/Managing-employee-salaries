using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Admin : Staff
    {
        private const float overTimeRate = 15.5f;
        private const float adminHourlyRate = 30f;
        public float OverTime { get; private set; }
        public Admin(string name):base(name, adminHourlyRate) 
        {
            role = "Admin";
        }
        public override void Calculate()
        {
            base.Calculate();
            if (HoursWorked > 160)
            {
                OverTime = overTimeRate * (HoursWorked - 160);
            }
            TotalPay += OverTime;
        }
    }
}
