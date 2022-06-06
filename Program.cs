using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraByte
{
    class Program
    {
        //Reynoso Rosales Eduardo Guadalupe #21212036
        static void Main(string[] args)
        {
            FileStream fs = null;

            byte[] buffer = new byte[81];

            int noBytes = 0, car;

           

            try
            {
                //Se crea el flujo
                fs = new FileStream("binarie.txt", FileMode.Create, FileAccess.Write);

                Console.WriteLine("Escriba un texto que deseé almacenar en el archivo: ");

                while ((car = Console.Read()) != '\r' && (noBytes < buffer.Length))
                {
                    buffer[noBytes] = (byte)car;
                    noBytes++;
                }
                fs.Write(buffer, 0, noBytes);


            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

        }
    }
}
