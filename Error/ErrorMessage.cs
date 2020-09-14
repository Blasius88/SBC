using System;
using System.IO;

namespace SBC.Error
{
    public class ErrorMessage
    {
        public static int i = 0;
        public static void ErrorWrite(string e)
        {
            i++;
            FileStream fileStream1 = new FileStream(@"C:\Users\Адамовна\Source\Repos\SBC\Error\log.txt", FileMode.Append);
            byte[] array = System.Text.Encoding.Default.GetBytes("\nCтрока " + i + " (" + DateTime.Now + ")" + "\n" + e + "\n");
            // запись массива байтов в файл
            fileStream1.Write(array, 0, array.Length);
            fileStream1.Close();
        }
    }
}
