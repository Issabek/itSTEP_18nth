using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

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
        public static void task131()
        {
            Assembly SampleAssembly = Assembly.LoadFrom("/Users/sensei.rin/Projects/itSTEP_11nth/Student/bin/Debug/netstandard2.1/Student.dll");
            Type[] tps = SampleAssembly.GetTypes();
            object obj = Activator.CreateInstance(SampleAssembly.GetTypes()[0]);
            obj.GetType().GetProperty("Name").SetValue(obj, "Test");
            obj.GetType().GetMethod("Print").Invoke(obj, new object[] { });
        }
        public static void task132()
        {
            Assembly SampleAssembly = Assembly.LoadFrom("/Users/sensei.rin/Projects/itSTEP_11nth/Student/bin/Debug/netstandard2.1/Student.dll");
            Type[] tps = SampleAssembly.GetTypes();
            object obj = Activator.CreateInstance(SampleAssembly.GetTypes()[0]);
            foreach (var item in obj.GetType().GetInterfaces())
            {
                Console.WriteLine(item);
            }
        }
        public static void task134(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.dll");
            List<Object> objs = new List<object>();
            foreach (var item in files)
            {
                Assembly SampleAssembly = Assembly.LoadFrom(item.FullName);
                Type[] tps = SampleAssembly.GetTypes();
                foreach (var it in SampleAssembly.GetTypes())
                {
                    object obj = Activator.CreateInstance(it);
                    if (obj.GetType().GetInterfaces().Length > 0)
                    {
                        objs.Add(obj);
                        Console.WriteLine(obj.GetType().Name);
                        obj.GetType().GetMethods()[0].Invoke(obj, new object[] { });
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            //task132();


            //task1();
            //task2();
            //task3("privet",4);
            //task4();
        }
    }
}
