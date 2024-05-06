using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class PaySlip
    {
        private int month;
        private int year;
        enum MonthesOfYear
        {
            Jan = 1,
            Feb = 2,
            Mar = 3,
            Apr = 4,
            May = 5,
            Jun = 6,
            Jul = 7,   
            Aug = 8,
            Sep = 9,
            Oct= 10,
            Nov= 11,
            Dec = 12
        }
        public PaySlip(int PayMonth ,  int PayYear)
        {
            month = PayMonth;
            year = PayYear;
        }
        public void GenteratePaySlip(List<Staff> MyStaff)
        {
            string HeaderPath = "C:\\Users\\ma247\\OneDrive\\Desktop\\";
            string path;
            foreach(Staff Staff in MyStaff)
            {
                path = string.Concat(HeaderPath,Staff.NameOfStaff,".txt");
                using (StreamWriter sw  = new StreamWriter(path))
                {
                    if(Staff is Manager)
                    {
                     Manager manager = (Manager)Staff;
                     sw.WriteLine($"PaySlip for {(MonthesOfYear)month} {year}\n" +
                                 $"==========================================\n" +
                                 $"Name Of Staff : {manager.NameOfStaff}\n" +
                                 $"Role : {manager.role}\n" +
                                 $"Hours Worked : {manager.HoursWorked}\n\n" +
                                 $"Basic Pay : ${manager.BasicPay}\n" +
                                ((manager.HoursWorked>160)? $"Allowance : {manager.Allowance} \n\n":"") +
                                 $"================================\n" +
                                 $"Total Pay : ${manager.TotalPay} \n" +
                                 $"=================================="); 
                    }
                    else if(Staff is Admin)
                    {
                        Admin admin = (Admin)Staff;
                        sw.WriteLine($"PaySlip for {(MonthesOfYear)month} {year}\n" +
                                 $"==========================================\n" +
                                 $"Name Of Staff : {admin.NameOfStaff}\n" +
                                 $"Role : {admin.role}\n" +
                                 $"Hours Worked : {admin.HoursWorked}\n\n" +
                                 $"Basic Pay : ${admin.BasicPay}\n" +
                                 $"OverTime Pay : {admin.OverTime} \n\n" +
                                 $"================================\n" +
                                 $"Total Pay : ${admin.TotalPay} \n" +
                                 $"==================================");
                    }
                    sw.Close();
                }
            }

        }
        public void GenerateSummary (List<Staff> MyStaff)
        {
            var staffs = MyStaff.Where(e => e.HoursWorked < 10).OrderBy(e => e.NameOfStaff);
            string path = "C:\\Users\\ma247\\OneDrive\\Desktop\\Summary.txt";
            if (staffs !=null)
            foreach(Staff Staff in staffs)
            {
            using (StreamWriter sw  = new StreamWriter(path))
            {
                sw.WriteLine($"Name Of Staff : {Staff.NameOfStaff}, Hours Worked : {Staff.HoursWorked}");
                    sw.Close();
            }

            }


        }

    }
}
