using System;
using System.Collections.Generic;
using System.Reflection;
namespace itSTEP_18nth
{
    class Program
    {
        public static void task1()
        {
            var s = typeof(Console).GetMethods();
            foreach (var item in s)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void task2()
        {
            tempclas tempclas = new tempclas("str", 420);
            Console.WriteLine(tempclas.GetType().GetProperties()[0]+" "+typeof(tempclas).GetProperties()[0].GetValue(tempclas)+ "  "+ tempclas.GetType().GetProperties()[1] + " " + typeof(tempclas).GetProperties()[1].GetValue(tempclas));
        }
        public static void task3(string str, int size)
        {
            var s = typeof(string).GetMethod("Substring", new [] {typeof(int),typeof(int)}).Invoke(str,new object[] { 0,size });
            Console.WriteLine(s);
        }
        public static void task4()
        {
            var s = typeof(List<>).GetConstructors();
            foreach(var item in s)
            {
                Console.Write(".ctor: ");
                foreach(var it in item.GetParameters())
                {
                    Console.Write(it+" ");
                }
                Console.WriteLine("");

            }
        }
        static void Main(string[] args)
        {
            //Assembly SampleAssembly;
            //SampleAssembly = Assembly.LoadFrom("Assembly.dll");
            //task1();
            //task2();
            //task3("privet",4);
            //task4();
            //13.1 в маке так нельзя сделать, из-за чего я не могу сделать и остальные задание относящиеся к этому
            //13.2 
            //13.4
        }
    }
}
