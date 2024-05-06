
using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
namespace Review
{
    internal class Program
    {

        static void Main(string[] args)
        {
          List<Staff> staffs = new List<Staff>();
            FileReader fileReader = new FileReader();
            int month = 0, year = 0;
           Console.Write("PLZ enter the year : ");
           year = int.Parse(Console.ReadLine());
            Console.Write("PLZ enter the month : ");
            month = int.Parse(Console.ReadLine());
            staffs = fileReader.ReadFile();
            foreach (Staff s in staffs)
            {
                Console.Write($"enter hours worked for {s.NameOfStaff} ({s.role}): ");
                s.HoursWorked = int.Parse(Console.ReadLine());
                s.Calculate();
                s.INFO();
            }
            PaySlip ps = new PaySlip(month,year);
            ps.GenteratePaySlip(staffs);
            ps.GenerateSummary(staffs);
           
        }
    }
}