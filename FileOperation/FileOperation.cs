using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperation
{
    internal class FileOperation
    {
        public string Path { get; set; }
        public string DestFilePath { get; set; }

        public FileOperation(string path, string destFilePath)
        {
            Path = path;
            DestFilePath = destFilePath;
        }

        public void RollFile()
        {
            var path = Path;
            var destFilePath = DestFilePath;

            if (CheckIfFileToCopyExist(path))
            {
                CopyFile(path, destFilePath);
            }
            else
            {
                Console.WriteLine("Nie znaleziono pliku o podanej ścieżce");
            }
        }

        public bool CheckIfFileToCopyExist(string path)
        {
            return File.Exists(path);
        }
        public bool CheckIfDestFileExist(string destFilePath)
        {
            if (File.Exists(destFilePath))
            {
                Console.WriteLine("Plik o tej nazwie juz istnieje");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CopyFile(string path, string destFilePath)
        {
            if (CheckIfDestFileExist(destFilePath))
            {
                File.Copy(path, destFilePath);
                Console.WriteLine("Plik został skopionowany");
            }
           
        }

    }
}
