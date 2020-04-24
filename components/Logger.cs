using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3analiza.components
{
    class Logger
    {
        public static Logger instance;
        string filePath;

        private Logger()
        {
            filePath = @"C:\temp.txt";
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                file.Write(message);
            }
        }

        public void SetFilepath(string filepathIn)
        {
            filePath = filepathIn;
        }
    }
}
