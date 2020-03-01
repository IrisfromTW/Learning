using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_practice
{
    class Employee
    {
        public string empID { get; set; }
        public string empName { get; set; }
 
        private int empSalary;
        public int EMPSalary {
            get { return empSalary; }
            set { empSalary = value < 22000 ? 22000 : value; }  
                }

        //建構式，名稱需與class名一樣
        public Employee(string id,string name,int salary)
        {
            num++;
            empID = id;
            empName = name;
            EMPSalary = salary;
        }

        //預設
        public Employee()
        {
            num++;
            empID = "送審中";
            empName = "莫宰羊";
            EMPSalary = 0;
        }



        public void showInfo()
        {
            Console.WriteLine("編號:" + empID);
            Console.WriteLine("姓名:" + empName);
            Console.WriteLine("薪水:" + empSalary + "元");
            Console.WriteLine("=======================");
        }

        //靜態型別
        private static int num;
        public static int Num
        {
            get { return num; }
        }
        public static void showNum()
        {
            Console.WriteLine("目前已建立{0}位員工資料!\n", num);
        }
    }
}
