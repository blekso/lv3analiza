using lv3analiza.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3analiza
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.zad
            Prototype data1 = new Dataset(@"C:\file.txt");
            foreach (List<string> listOfStrings in data1.GetData())
            {
                foreach (string str in listOfStrings)
                {
                    Console.Write(str);
                }
            }
            Prototype data2 = data1.Clone();

            //2.zad
            MatrixGenerator matrixGenerator = MatrixGenerator.GetInstance();
            float[][] matrix = matrixGenerator.CreateMatrix(5, 5);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
            }

            //3.zad
            Logger logger = Logger.GetInstance();
            logger.SetFilepath(@"C:\log.txt");
            Console.ReadLine();

            //4.zad
            ConsoleNotification notification = new ConsoleNotification("Mihael", "Notif", "Text", DateTime.Now, Category.ERROR, ConsoleColor.DarkBlue);
            NotificationManager notifManager = new NotificationManager();
            notifManager.Display(notification);
        }
    }
}
