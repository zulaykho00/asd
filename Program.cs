using System;

namespace ddzz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZADANIE#1");
            double a=16.80, b=12.40,c=1,d=1;
            c=a*b;
            d=Math.Sqrt(c);
            Console.WriteLine(d);
            Console.WriteLine("!!!!!ZADANIE#2!!!!!");
            double A=1.40, B=-5.50, C=0.60, AC, BC, S;
              
            AC=Math.Abs(C-A);
            BC=Math.Abs(B-C);
            S=AC+BC;
            Console.WriteLine($"AC:{AC}   BC:{BC}   S:{S}");
            Console.WriteLine("!!!!!ZADANIE#3!!!!!");
            double x1=-6.20, x2=2.10, y1=5.20, y2=9.80, z1,z2,z3;
            z1=Math.Pow(x2-x1,2);
             z2=Math.Pow(y2-y1,2);
             z3=Math.Sqrt(z1+z2);
             Console.WriteLine($"Z3:{z3}");
             Console.WriteLine("!!!!!ZADANIE#4!!!!!");
             int ax,bx,cx;
             ax=Convert.ToInt32(Console.ReadLine());
             bx=ax%10;
             cx=ax/10;
             ax=bx*10+cx;
             Console.WriteLine(ax);
             Console.WriteLine("!!!!!ZADANIE#5!!!!!");
             int n, k1,k2;
             n=Convert.ToInt32(Console.ReadLine());
             k1=n/60;
             k2=n/3600;
             Console.WriteLine($"minutes={k1}   hours={k2}");
             Console.WriteLine("!!!!!ZADANIE#6!!!!!");
             int k;
             k=Convert.ToInt32(Console.ReadLine());
             k=k%7;
             Console.WriteLine($"номер дня недели:{k}");



        }
    }
}
