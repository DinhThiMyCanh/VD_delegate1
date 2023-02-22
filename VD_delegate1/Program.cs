using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_delegate1
{
    class Program
    {
        //Hàm ủy quyền Delegate
        delegate double processDelegate(double a, double b);
        //Biểu thức Lambda
        static double cong(double a, double b)=> a + b;
        
        static double tru(double a, double b) =>a - b;
        static double nhan(double a, double b)=> a * b;
        
        static double chia(double a, double b) =>a / b;
        static void Main(string[] args)
        {
            double a = 3;
            double b = 5;
            processDelegate process;
            Console.Write("Nhap phep tinh (+,-,*,/)");
            string pt = Console.ReadLine();
            if (pt == "+")
            {
                process = new processDelegate(cong);
            }
            else
                if (pt == "-")
                    process = new processDelegate(tru);
                else
                    if (pt =="*")
                         process = new processDelegate(nhan);
                    else
                        process = new processDelegate(chia);
            Console.WriteLine($"Ket qua:{process(a, b)}");
            Console.ReadKey();
        }
    }
}
