using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Staff
    {
        private float HourRate;
        private int Hworked;
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string role { get; protected set; }
        public string? NameOfStaff { get; set; }
        public int HoursWorked 
        {
            get{return Hworked;}
            set { Hworked = (value > 0) ? value : 0; }  
        }
        public Staff(string name , float Hourrate)
        {
            NameOfStaff = name; 
            HourRate= Hourrate;
        }
        public virtual void  Calculate()
        {
            Console.WriteLine("Calculating Pay…");
            BasicPay = Hworked * HourRate;
            TotalPay = BasicPay; 
        }
        public virtual void INFO()
        {
            Console.WriteLine("name of staff : {0}\n Salary {1}", NameOfStaff,TotalPay);

        }
       
    }
}
