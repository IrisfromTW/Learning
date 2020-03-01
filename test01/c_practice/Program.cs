using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle() { width=20,height=10};
            Console.WriteLine("矩形寬={0}, 長={1}, 面積={2}", r1.width, r1.height, r1.getArea());
            Triangle t1 = new Triangle() { width=20,height=10};
            t1.showData();
            Rectangle.showNum();
            //Employee Class練習

            Employee num1 = new Employee();
            num1.empID = "A0001";
            num1.empName = "Jacky";
            num1.EMPSalary = 50000;
            num1.showInfo();

            Employee num2 = new Employee() { empID = "A0002", empName = "Kelly", EMPSalary = 158 };
            num2.showInfo();

            Employee num3 = new Employee("A0003", "Helsay",30000);
            num3.showInfo();

            Employee num4 = new Employee();
            num4.showInfo();

            Employee[] per = new Employee[5];
            per[0] = new Employee();
            per[0].empID = "A0005";
            per[0].empName = "Peach";
            per[0].EMPSalary = 32000;
            per[1] = new Employee();
            per[1].empID = "A0006";per[1].empName = "Queen";per[1].EMPSalary = 54236;

            string keyName = "", keyID = "";
            int keySalary = 0;
            Console.Write("請輸入欲輸入員工比數:");
            int keyinSum = int.Parse(Console.ReadLine());
            Employee[] per2 = new Employee[keyinSum];
            for(int i = 0; i < keyinSum; i++)
            {
                Console.Write("編號:");
                keyID = Console.ReadLine();
                Console.Write("姓名:");
                keyName = Console.ReadLine();
                Console.Write("薪水:");
                keySalary = int.Parse(Console.ReadLine());
                per2[i] = new Employee();
                per2[i].empID = keyID;
                per2[i].empName = keyName;
                per2[i].EMPSalary = keySalary;
                per2[i].showInfo();
            }


            Employee.showNum();

            //課後練習1
            bool r = true;
            string keyin = "";
            do
            {
                Console.Write("請輸入1-9或/符號:");
                keyin = Console.ReadLine();
                show(keyin,ref r);
            } while (r);
            Console.Read();
        }

        //課後練習1
        static void show(string keyin,ref bool r)
        {
            string sum = "";
            if (keyin == "/") { 
                r = false;
                Console.WriteLine("結束程式");
            }
            else
            {
                for(int i = 1; i <= int.Parse(keyin); i++)
                {
                    sum += "*";
                }
                Console.WriteLine(sum);
            }
        }

        //多載練習
        static int op(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int op(int a ,int b,int c)
        {
            if(a>=b && a >= c)
            {
                return a;
            }else if(b>=a && b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }


        //遞迴計算
        static int sumCompute(int num)
        {
            int sum = 0;
            for(int i = 0; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }



        //陣列最大值
        static int getMax(int[] myArray)
        {

            int max = 0;
            foreach(int item in myArray)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        //隨機亂數陣列(不重複)
        static int[] getRun(int num,int min ,int max)
        {
            int[] ary = new int[num];
            Random r = new Random();
            int check =0,i=0;
            bool flag = true;
            do
            {
                flag = true;
                check = r.Next(min, max + 1);
                for (int k = 0; k < ary.Length; k++)
                {
                    if (check == ary[k])
                    {
                        flag = !flag;
                        break;
                    }
                }
                if (flag)
                {
                    ary[i] = check;
                    i++;
                }
            } while (i < num);
            return ary;
        }


        //圓體積計算
        static double compute(int r)
        {
            double pi = 3.1416;
            return 4.0/3.0*pi*r*r*r;
        }

        //閏年判斷
        static void CheckYear(int y, ref string s1)
        {
            if((y%4==0 && y%100 !=0) || (y % 400 == 0))
            {
                s1="此為閏年";
            }
            else
            {
                s1="不是拉";
            }
        }
    }
}
