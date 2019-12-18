using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string task = "";
            string a = "";
            string b = "";
            EN L = new EN();

            while (loop)
            {
                F.W("\n\n1 - " + L.Sum + "\n2 - " + L.Diff + "\n3 - " + L.Times + "\n4 - " + L.DividedBy + "\n\n0 - " + L.Exit + "\n\n" + L.Select + ": ");
                switch (F.RL())
                {
                    case "1":
                        task = L.Sum;
                        F.W(task + L.FirstNumber);
                        a = F.RL();
                        F.W(task + L.SecondNumber);
                        b = F.RL();
                        try
                        {
                            F.WL(task + L.Result + F.Sum(a, b));
                        }
                        catch (Exception ex)
                        {
                            F.WL(L.Err);
                        }
                        Thread.Sleep(2000);
                        break;
                    case "2":
                        task = L.Diff;
                        F.W(task + L.FirstNumber);
                        a = F.RL();
                        F.W(task + L.SecondNumber);
                        b = F.RL();
                        try
                        {
                            F.WL(task + L.Result + F.Diff(a, b));
                        }
                        catch (Exception ex)
                        {
                            F.WL(L.Err);
                        }
                        Thread.Sleep(2000);
                        break;
                    case "3":
                        task = L.Times;
                        F.W(task + L.FirstNumber);
                        a = F.RL();
                        F.W(task + L.SecondNumber);
                        b = F.RL();
                        try
                        {
                            F.WL(task + L.Result + F.Times(a, b));
                        }
                        catch (Exception ex)
                        {
                            F.WL(L.Err);
                        }
                        Thread.Sleep(2000);
                        break;
                    case "4":
                        task = L.DividedBy;
                        F.W(task + L.FirstNumber);
                        a = F.RL();
                        F.W(task + L.SecondNumber);
                        b = F.RL();
                        try
                        {
                            F.WL(task + L.Result + F.DividedBy(a, b));
                        }
                        catch (Exception ex)
                        {
                            F.WL(L.Err);
                        }
                        Thread.Sleep(2000);
                        break;
                    case "0":
                        loop = false;
                        break;
                }
            }
        }
    }
}
