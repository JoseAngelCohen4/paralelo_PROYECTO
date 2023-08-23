using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace paralelo_PROYECTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Jose\Documents\Nueva carpeta\";
            string path2 = @"C:\Users\Jose\Documents\Nueva carpeta (2)\";

            string[] lst = Directory.GetFiles(path1);
            Random r = new Random(1000);
            Parallel.ForEach(lst, (archivo) =>
            {
                r.Next();
                int a = r.Next();

                File.Copy(archivo, path2 + "a" + a + ".txt");
            });
          

        }
    }
}
