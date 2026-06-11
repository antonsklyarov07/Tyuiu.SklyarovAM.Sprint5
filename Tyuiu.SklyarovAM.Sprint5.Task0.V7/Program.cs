using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint5.Task0.V7.Lib;
namespace Tyuiu.SklyarovAM.Sprint5.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение X = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}
