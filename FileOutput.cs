using System;
using System.IO;

namespace MobileAppModule1
{
    class FileOutput
    {
        private StreamWriter writer = null;
        private string fileName;

        public FileOutput(string fileName)
        {
            this.fileName = fileName;
            try
            {
                writer = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {fileName} {e}");
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                writer.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Write Error: {fileName} {e}");
            }
        }

        public void FileClose()
        {
            if (writer != null)
            {
                try
                {
                    writer.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error closing file: {fileName} {e}");
                }
            }
        }
    }
}