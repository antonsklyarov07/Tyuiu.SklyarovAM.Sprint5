using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SklyarovAM.Sprint5.Task0.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            z = Math.Round(z, 3);
            File.WriteAllText(path, z.ToString("F3", CultureInfo.InvariantCulture)); 
            return path;
        }
    }
}
