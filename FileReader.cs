using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class FileReader
    {
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "C:\\Users\\ma247\\OneDrive\\Desktop\\myfile.txt";
            char[] separator = { ',' };
            if (File.Exists(path))
            {
               using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                     var  line = sr.ReadLine().Split(separator);
                     result[0] = line[0].Trim();
                     result[1] = line[1].Trim();
                        if (string.Compare(result[1], "manager", true) == 0)
                        {
                            Staff manager = new Manager(line[0]);
                            myStaff.Add(manager);

                        }
                        else if (string.Compare(result[1], "admin", true) == 0)
                        {
                            Staff admin = new Admin(line[0]);
                            myStaff.Add(admin);
                        }
                    




                    }
                    sr.Close();

                }

               
            }
            else
                Console.WriteLine("check file path ...");
            return myStaff;
        }
    }
}
