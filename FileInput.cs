using System;
using System.IO;

namespace MobileAppModule1
{
    class FileInput
    {
        private StreamReader reader = null;
        private string fileName;

        public FileInput(string fileName)
        {
            this.fileName = fileName;
            try
            {
                reader = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {fileName} {e}");
            }
        }

        public void FileRead()
        {
            string line;
            try
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {fileName} {e}");
            }
        }

        public string FileReadLine()
        {
            try
            {
                string line = reader.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {fileName} {e}");
                return null;
            }
        }

        public void FileClose()
        {
            if (reader != null)
            {
                try
                {
                    reader.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error closing file: {fileName} {e}");
                }
            }
        }
    }
}